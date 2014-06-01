using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace POEZoomHack
{
    class Memory
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        private static Process[] processes;
        private static int SelectedProcess = 0;

        public static void SetProcesses(Process[] _processes)
        {
            processes = _processes;
        }

        public static void SelectProcess(int index)
        {
            SelectedProcess = index;
        }

        public static void Write<T>(IntPtr address, T value)
        {
            if (processes == null || processes.Length == 0)
                return;

            TypeCode typeCode = Type.GetTypeCode(typeof(T));

            byte[] bytes;

            object val = value;

            switch (typeCode)
            {
                case TypeCode.Single:
                    bytes = BitConverter.GetBytes((float)val);
                    break;
                // TODO: Handle more types...
                default:
                    throw new NotSupportedException(typeCode.ToString());
            }

            int bytesWritten;
            if (!WriteProcessMemory(processes[SelectedProcess].Handle, address, bytes, bytes.Length, out bytesWritten))
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public static T Read<T>(IntPtr address)
        {
            if (processes == null || processes.Length == 0)
                return default(T);

            object ret;
            Type tType = typeof(T);
            byte[] bytes;

            if (tType == typeof(IntPtr))
            {
                bytes = ReadBytes(address, 4);
                ret = new IntPtr(BitConverter.ToInt32(bytes, 0));
                return (T)ret;
            }

            TypeCode typeCode = Type.GetTypeCode(tType);

            switch (typeCode)
            {
                case TypeCode.Single:
                    bytes = ReadBytes(address, 4);
                    ret = BitConverter.ToSingle(bytes, 0);
                    break;
                case TypeCode.Int32:
                    bytes = ReadBytes(address, 4);
                    ret = BitConverter.ToInt32(bytes, 0);
                    break;
                case TypeCode.String:
                    bytes = ReadBytes(address, 512);
                    ret = Encoding.UTF8.GetString(bytes.TakeWhile(b => b != 0).ToArray());
                    break;
                // TODO: Handle more types...
                default:
                    throw new NotSupportedException(typeCode.ToString());
            }

            return (T)ret;
        }

        private static byte[] ReadBytes(IntPtr address, int size)
        {
            byte[] bytes = new byte[size];

            int bytesRead;

            if (!ReadProcessMemory(processes[SelectedProcess].Handle, address, bytes, bytes.Length, out bytesRead))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return bytes;
        }
    }
}
