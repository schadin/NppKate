﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NppGit.Interop
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CWPSTRUCT
    {
        public IntPtr lParam;
        public IntPtr wParam;
        public uint   message;
        public IntPtr hwnd;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct CWPRETSTRUCT
    {
        public IntPtr lResult;
        public IntPtr lParam;
        public IntPtr wParam;
        public uint   message;
        public IntPtr hwnd;
    }
}