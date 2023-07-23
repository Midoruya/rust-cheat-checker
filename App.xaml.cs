﻿using System.Threading;
using System.Windows;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using RCC.windows;
using MessageBox = RCC.windows.MessageBox;

namespace RCC
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
#if !DEBUG
            bool isAdmin = Utilities.IsAdminStartup();
            if (!isAdmin)
            {
                MessageBox.Show("Please run it's program from admin");
                Environment.Exit(Environment.ExitCode);
            } 
            Utilities.CheckOnUpdate();
            Utilities.OpenDiscordServer();
#endif
            new Notify().Show("title","message");
            DetectingCleaning.Start();
            main_window main = new main_window();
            main.Show();
        }
    }
}
