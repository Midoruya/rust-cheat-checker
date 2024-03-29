﻿using System.Collections.Generic;
using System.Threading;
using RCC.Modules.Device.KeyboardEvent;
using RCC.Windows;

namespace RCC.Modules.AutoCheck.KeyboardCheck;

public class KeyboardCheck : IKeyboardCheck
{
    private readonly IKeyboardEvent<KeyboardKeys> _keyboardEvent;

    public KeyboardCheck(IKeyboardEvent<KeyboardKeys> keyboardEvent)
    {
        _keyboardEvent = keyboardEvent;
    }

    public List<List<KeyboardKeys>> CheckKeyList { get; } = new()
    {
        new List<KeyboardKeys> { KeyboardKeys.Return },
        new List<KeyboardKeys> { KeyboardKeys.Return },
        new List<KeyboardKeys> { KeyboardKeys.Return },
        new List<KeyboardKeys> { KeyboardKeys.A },
        new List<KeyboardKeys> { KeyboardKeys.B },
        new List<KeyboardKeys> { KeyboardKeys.C },
        new List<KeyboardKeys> { KeyboardKeys.D },
        new List<KeyboardKeys> { KeyboardKeys.E },
        new List<KeyboardKeys> { KeyboardKeys.F },
        new List<KeyboardKeys> { KeyboardKeys.G },
        new List<KeyboardKeys> { KeyboardKeys.H },
        new List<KeyboardKeys> { KeyboardKeys.I },
        new List<KeyboardKeys> { KeyboardKeys.J },
        new List<KeyboardKeys> { KeyboardKeys.K },
        new List<KeyboardKeys> { KeyboardKeys.L },
        new List<KeyboardKeys> { KeyboardKeys.M },
        new List<KeyboardKeys> { KeyboardKeys.N },
        new List<KeyboardKeys> { KeyboardKeys.O },
        new List<KeyboardKeys> { KeyboardKeys.P },
        new List<KeyboardKeys> { KeyboardKeys.Q },
        new List<KeyboardKeys> { KeyboardKeys.R },
        new List<KeyboardKeys> { KeyboardKeys.S },
        new List<KeyboardKeys> { KeyboardKeys.T },
        new List<KeyboardKeys> { KeyboardKeys.U },
        new List<KeyboardKeys> { KeyboardKeys.V },
        new List<KeyboardKeys> { KeyboardKeys.W },
        new List<KeyboardKeys> { KeyboardKeys.X },
        new List<KeyboardKeys> { KeyboardKeys.Y },
        new List<KeyboardKeys> { KeyboardKeys.Z },
        new List<KeyboardKeys> { KeyboardKeys.D0 },
        new List<KeyboardKeys> { KeyboardKeys.D1 },
        new List<KeyboardKeys> { KeyboardKeys.D2 },
        new List<KeyboardKeys> { KeyboardKeys.D3 },
        new List<KeyboardKeys> { KeyboardKeys.D4 },
        new List<KeyboardKeys> { KeyboardKeys.D5 },
        new List<KeyboardKeys> { KeyboardKeys.D6 },
        new List<KeyboardKeys> { KeyboardKeys.D7 },
        new List<KeyboardKeys> { KeyboardKeys.D8 },
        new List<KeyboardKeys> { KeyboardKeys.D9 },
        new List<KeyboardKeys> { KeyboardKeys.Space },
        new List<KeyboardKeys> { KeyboardKeys.Escape },
        new List<KeyboardKeys> { KeyboardKeys.Pause },
        new List<KeyboardKeys> { KeyboardKeys.Menu },
        new List<KeyboardKeys> { KeyboardKeys.AltRight },
        new List<KeyboardKeys> { KeyboardKeys.AltLeft },
        new List<KeyboardKeys> { KeyboardKeys.ControlRight },
        new List<KeyboardKeys> { KeyboardKeys.ShiftRight },
        new List<KeyboardKeys> { KeyboardKeys.ShiftLeft },
        new List<KeyboardKeys> { KeyboardKeys.ControlLeft },
        new List<KeyboardKeys> { KeyboardKeys.Tab },
        new List<KeyboardKeys> { KeyboardKeys.Return },
        new List<KeyboardKeys> { KeyboardKeys.Back },
        new List<KeyboardKeys> { KeyboardKeys.Insert },
        new List<KeyboardKeys> { KeyboardKeys.Delete },
        new List<KeyboardKeys> { KeyboardKeys.Home },
        new List<KeyboardKeys> { KeyboardKeys.End },
        new List<KeyboardKeys> { KeyboardKeys.Up },
        new List<KeyboardKeys> { KeyboardKeys.Down },
        new List<KeyboardKeys> { KeyboardKeys.Left },
        new List<KeyboardKeys> { KeyboardKeys.Right },
        new List<KeyboardKeys> { KeyboardKeys.F1 },
        new List<KeyboardKeys> { KeyboardKeys.F2 },
        new List<KeyboardKeys> { KeyboardKeys.F3 },
        new List<KeyboardKeys> { KeyboardKeys.F4 },
        new List<KeyboardKeys> { KeyboardKeys.F5 },
        new List<KeyboardKeys> { KeyboardKeys.F6 },
        new List<KeyboardKeys> { KeyboardKeys.F7 },
        new List<KeyboardKeys> { KeyboardKeys.F8 },
        new List<KeyboardKeys> { KeyboardKeys.F9 },
        new List<KeyboardKeys> { KeyboardKeys.F10 },
        new List<KeyboardKeys> { KeyboardKeys.F11 },
        new List<KeyboardKeys> { KeyboardKeys.F12 },
        new List<KeyboardKeys> { KeyboardKeys.F13 },
        new List<KeyboardKeys> { KeyboardKeys.F14 },
        new List<KeyboardKeys> { KeyboardKeys.F15 },
        new List<KeyboardKeys> { KeyboardKeys.F16 },
        new List<KeyboardKeys> { KeyboardKeys.F17 },
        new List<KeyboardKeys> { KeyboardKeys.F18 },
        new List<KeyboardKeys> { KeyboardKeys.F19 },
        new List<KeyboardKeys> { KeyboardKeys.F20 },
        new List<KeyboardKeys> { KeyboardKeys.F21 },
        new List<KeyboardKeys> { KeyboardKeys.F22 },
        new List<KeyboardKeys> { KeyboardKeys.F23 },
        new List<KeyboardKeys> { KeyboardKeys.F24 },
        new List<KeyboardKeys> { KeyboardKeys.NumLock },
        new List<KeyboardKeys> { KeyboardKeys.Apps },
        new List<KeyboardKeys> { KeyboardKeys.Clear },
        new List<KeyboardKeys> { KeyboardKeys.Divide },
        new List<KeyboardKeys> { KeyboardKeys.Multiply },
        new List<KeyboardKeys> { KeyboardKeys.Subtract },
        new List<KeyboardKeys> { KeyboardKeys.Add },
        new List<KeyboardKeys> { KeyboardKeys.Decimal },
        new List<KeyboardKeys> { KeyboardKeys.NumPad0 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad1 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad2 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad3 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad4 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad5 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad6 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad7 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad8 },
        new List<KeyboardKeys> { KeyboardKeys.NumPad9 },
        new List<KeyboardKeys> { KeyboardKeys.Capital },
        new List<KeyboardKeys> { KeyboardKeys.Print },
        new List<KeyboardKeys> { KeyboardKeys.Prior },
        new List<KeyboardKeys> { KeyboardKeys.Scroll },
        new List<KeyboardKeys> { KeyboardKeys.Next },
        new List<KeyboardKeys> { KeyboardKeys.Select },
        new List<KeyboardKeys> { KeyboardKeys.Execute },
        new List<KeyboardKeys> { KeyboardKeys.Help },
        new List<KeyboardKeys> { KeyboardKeys.Snapshot },
        new List<KeyboardKeys> { KeyboardKeys.LWindows },
        new List<KeyboardKeys> { KeyboardKeys.RWindows }
    };

    public void Run()
    {
        new MessageBox("Проверка клавиатуры успешно запушенна\nначнётся через 10 секунд").Show();
        Thread.Sleep(10000); // Sleep ten seconds
        CheckKeyList.ForEach(item => { _keyboardEvent.SendEvent(item); });
        new MessageBox("Проверка клавиатуры успешно завершена").Show();
    }
}