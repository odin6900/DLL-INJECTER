using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;

namespace INJECTER
{
    public partial class Form1 : Form
    {
        // DLL Injector constants
        private const int PROCESS_CREATE_THREAD = 0x0002;
        private const int PROCESS_QUERY_INFORMATION = 0x0400;
        private const int PROCESS_VM_OPERATION = 0x0008;
        private const int PROCESS_VM_WRITE = 0x0020;
        private const int PROCESS_VM_READ = 0x0010;
        private const uint MEM_COMMIT = 0x1000;
        private const uint PAGE_READWRITE = 0x04;

        // P/Invoke imports
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, out IntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool CloseHandle(IntPtr hObject);

        public Form1()
        {
            InitializeComponent();
            RefreshDLLList();
            Log("[System Ready]");
        }

        // ── Window chrome handlers (borderless) ────────────────────────────
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        // Logging function
        private void Log(string message)
        {
            Sta.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
            Sta.ScrollToCaret();
        }

        // Set Process button click - open process selector
        private void btnSetProcess_Click(object sender, EventArgs e)
        {
            using (ProcessSelector ps = new ProcessSelector())
            {
                if (ps.ShowDialog(this) == DialogResult.OK)
                {
                    ProcessName.Text = ps.SelectedProcessName;
                    Log($"[*] Process set to: {ps.SelectedProcessName}");
                }
            }
        }

        // Refresh DLL list from application folder
        private void RefreshDLLList()
        {
            try
            {
                string folder = Application.StartupPath;
                string[] dllFiles = Directory.GetFiles(folder, "*.dll");
                listBoxDLLs.Items.Clear();
                foreach (string dll in dllFiles)
                    listBoxDLLs.Items.Add(Path.GetFileName(dll));
                Log($"Found {dllFiles.Length} DLL(s) in application folder");
            }
            catch (Exception ex)
            {
                Log($"[ERROR] Failed to refresh DLL list: {ex.Message}");
            }
        }

        // Browse for DLL files
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "DLL Files (*.dll)|*.dll|All Files (*.*)|*.*",
                Multiselect = true,
                Title = "Select DLL(s) to Inject"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in ofd.FileNames)
                {
                    if (!listBoxDLLs.Items.Contains(file))
                        listBoxDLLs.Items.Add(file);
                }
                // Select all so inject runs immediately
                for (int i = 0; i < listBoxDLLs.Items.Count; i++)
                    listBoxDLLs.SetSelected(i, true);
                Log($"Added {ofd.FileNames.Length} DLL(s) from browser");
            }
        }

        // Refresh button click
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDLLList();
        }

        // Clear logs button click
        private void btnClearLogs_Click(object sender, EventArgs e)
        {
            Sta.Clear();
            Log("[System Ready]");
        }

        // Inject DLL from file path
        private bool InjectDLL(string processName, string dllPath)
        {
            try
            {
                if (!File.Exists(dllPath))
                {
                    Log($"[ERROR] DLL not found: {dllPath}");
                    return false;
                }

                Process[] targetProcesses = Process.GetProcessesByName(processName);
                if (targetProcesses.Length == 0)
                {
                    Log($"[ERROR] Process '{processName}' not found. Please open it first!");
                    return false;
                }

                Process targetProcess = targetProcesses[0];
                Log($"[*] Found target process: {processName} (PID: {targetProcess.Id})");

                IntPtr hProcess = OpenProcess(PROCESS_CREATE_THREAD | PROCESS_QUERY_INFORMATION | PROCESS_VM_OPERATION | PROCESS_VM_WRITE | PROCESS_VM_READ, false, targetProcess.Id);
                if (hProcess == IntPtr.Zero)
                {
                    Log($"[ERROR] Failed to open process handle");
                    return false;
                }

                Log($"[*] Opened process handle");

                IntPtr loadLibraryAddr = GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA");
                if (loadLibraryAddr == IntPtr.Zero)
                {
                    Log($"[ERROR] Failed to find LoadLibraryA address");
                    CloseHandle(hProcess);
                    return false;
                }

                Log($"[*] Found LoadLibraryA at 0x{loadLibraryAddr.ToString("X")}");

                byte[] dllPathBytes = Encoding.ASCII.GetBytes(dllPath);
                IntPtr allocMemAddress = VirtualAllocEx(hProcess, IntPtr.Zero, (IntPtr)dllPathBytes.Length, MEM_COMMIT, PAGE_READWRITE);
                if (allocMemAddress == IntPtr.Zero)
                {
                    Log($"[ERROR] Failed to allocate memory in target process");
                    CloseHandle(hProcess);
                    return false;
                }

                Log($"[*] Allocated memory at 0x{allocMemAddress.ToString("X")}");

                if (!WriteProcessMemory(hProcess, allocMemAddress, dllPathBytes, (uint)dllPathBytes.Length, out IntPtr bytesWritten))
                {
                    Log($"[ERROR] Failed to write DLL path to target process memory");
                    CloseHandle(hProcess);
                    return false;
                }

                Log($"[*] Wrote {bytesWritten} bytes to target process");

                IntPtr threadHandle = CreateRemoteThread(hProcess, IntPtr.Zero, IntPtr.Zero, loadLibraryAddr, allocMemAddress, 0, IntPtr.Zero);
                if (threadHandle == IntPtr.Zero)
                {
                    Log($"[ERROR] Failed to create remote thread");
                    CloseHandle(hProcess);
                    return false;
                }

                Log($"[*] Created remote thread successfully");
                Log($"[SUCCESS] DLL injected: {Path.GetFileName(dllPath)}");

                CloseHandle(threadHandle);
                CloseHandle(hProcess);
                return true;
            }
            catch (Exception ex)
            {
                Log($"[ERROR] Exception during injection: {ex.Message}");
                return false;
            }
        }

        // Main inject button click
        private void btnInject_Click(object sender, EventArgs e)
        {
            try
            {
                string procName = ProcessName.Text.Trim();
                if (procName.EndsWith(".exe", StringComparison.OrdinalIgnoreCase))
                    procName = procName.Substring(0, procName.Length - 4);

                if (string.IsNullOrEmpty(procName))
                {
                    Log("[ERROR] Please enter a process name!");
                    return;
                }

                if (listBoxDLLs.Items.Count == 0)
                {
                    Log("[ERROR] No DLLs in list. Add a DLL first!");
                    return;
                }

                // Verify process is running
                Process[] targetProcesses = Process.GetProcessesByName(procName);
                if (targetProcesses.Length == 0)
                {
                    Log($"[ERROR] Process '{procName}.exe' is not running!");
                    return;
                }

                Log($"\n========== INJECTION SESSION START ==========");
                Log($"Target Process: {procName}.exe");
                Log($"DLLs to Inject: {listBoxDLLs.Items.Count}");
                Log($"===========================================\n");

                int successCount = 0;
                int failCount = 0;

                foreach (string dllItem in listBoxDLLs.Items)
                {
                    string dllPath = dllItem;
                    
                    // If it's just a filename, look for it in the app folder
                    if (!Path.IsPathRooted(dllItem))
                    {
                        dllPath = Path.Combine(Application.StartupPath, dllItem);
                    }

                    if (InjectDLL(procName, dllPath))
                        successCount++;
                    else
                        failCount++;

                    System.Threading.Thread.Sleep(500); // Small delay between injections
                }

                Log($"\n========== INJECTION SESSION END ==========");
                Log($"Successful: {successCount} | Failed: {failCount}");
                Log($"==========================================\n");
            }
            catch (Exception ex)
            {
                Log($"[ERROR] Fatal error: {ex.Message}");
            }
        }
    }
}
