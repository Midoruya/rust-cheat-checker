﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace RCC.Modules.Device.KeyboardEvent
{
    public enum KeyboardKeys : byte
    {
        Back = 0x08,
        Tab = 0x09,
        Clear = 0x0C,
        Return = 0x0D,
        ShiftLeft = 0xA0,
        ControlLeft = 0xA2,
        ShiftRight = 0xA1,
        ControlRight = 0xA3,
        AltLeft = 0xA4,
        AltRight = 0xA5,
        Menu = 0x12,
        Pause = 0x13,
        Capital = 0x14,
        Escape = 0x1B,
        Space = 0x20,
        Prior = 0x21,
        Next = 0x22,
        End = 0x23,
        Home = 0x24,
        Left = 0x25,
        Up = 0x26,
        Right = 0x27,
        Down = 0x28,
        Select = 0x29,
        Print = 0x2A,
        Execute = 0x2B,
        Snapshot = 0x2C,
        Insert = 0x2D,
        Delete = 0x2E,
        Help = 0x2F,
        D0 = 0x30,
        D1 = 0x31,
        D2 = 0x32,
        D3 = 0x33,
        D4 = 0x34,
        D5 = 0x35,
        D6 = 0x36,
        D7 = 0x37,
        D8 = 0x38,
        D9 = 0x39,
        A = 0x41,
        B = 0x42,
        C = 0x43,
        D = 0x44,
        E = 0x45,
        F = 0x46,
        G = 0x47,
        H = 0x48,
        I = 0x49,
        J = 0x4A,
        K = 0x4B,
        L = 0x4C,
        M = 0x4D,
        N = 0x4E,
        O = 0x4F,
        P = 0x50,
        Q = 0x51,
        R = 0x52,
        S = 0x53,
        T = 0x54,
        U = 0x55,
        V = 0x56,
        W = 0x57,
        X = 0x58,
        Y = 0x59,
        Z = 0x5A,
        LWindows = 0x5B,
        RWindows = 0x5C,
        Apps = 0x5D,
        NumPad0 = 0x60,
        NumPad1 = 0x61,
        NumPad2 = 0x62,
        NumPad3 = 0x63,
        NumPad4 = 0x64,
        NumPad5 = 0x65,
        NumPad6 = 0x66,
        NumPad7 = 0x67,
        NumPad8 = 0x68,
        NumPad9 = 0x69,
        Multiply = 0x6A,
        Add = 0x6B,
        Separator = 0x6C,
        Subtract = 0x6D,
        Decimal = 0x6E,
        Divide = 0x6F,
        F1 = 0x70,
        F2 = 0x71,
        F3 = 0x72,
        F4 = 0x73,
        F5 = 0x74,
        F6 = 0x75,
        F7 = 0x76,
        F8 = 0x77,
        F9 = 0x78,
        F10 = 0x79,
        F11 = 0x7A,
        F12 = 0x7B,
        F13 = 0x7C,
        F14 = 0x7D,
        F15 = 0x7E,
        F16 = 0x7F,
        F17 = 0x80,
        F18 = 0x81,
        F19 = 0x82,
        F20 = 0x83,
        F21 = 0x84,
        F22 = 0x85,
        F23 = 0x86,
        F24 = 0x87,
        NumLock = 0x90,
        Scroll = 0x91,
    }

    public class KeyboardEvent : IKeyboardEvent<KeyboardKeys>
    {
        public KeyboardEvent()
        {
            Debug.WriteLine("INIT KeyboardEvent");
        }

        public void PasteEvent()
        {
            Debug.WriteLine(Clipboard.GetText());
            Debug.WriteLine("PASTE!!!!");
            List<KeyboardKeys> eventList = new List<KeyboardKeys>()
            {
                KeyboardKeys.ControlLeft,
                KeyboardKeys.V,
            };
            SendEvent(eventList);
        }

        public void SendEvent(KeyboardKeys key, int interval = 0)
        {
            AllDllImport.keybd_event((byte)key, 0, 0, 0);
            Thread.Sleep(interval != 0 ? interval : 100);
            AllDllImport.keybd_event((byte)key, 0, 0x2, 0);
        }

        public void SendEvent(List<KeyboardKeys>? keys, int interval = 0)
        {
            if (keys == null) return;
            keys.ForEach(key => AllDllImport.keybd_event((byte)key, 0, 0, 0));
            Thread.Sleep(interval != 0 ? interval : 100);
            keys.ForEach(key => AllDllImport.keybd_event((byte)key, 0, 0x2, 0));
        }
    }
}