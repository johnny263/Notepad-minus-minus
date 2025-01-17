﻿using System;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using Dark.Net;
using NotePadMinusMinus;
using static System.Windows.Forms.DataFormats;

namespace darknet_demo_winforms;

internal static class Program
{
    public static readonly ThemeOptions ThemeOptions = new() {};

    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        IDarkNet darkNet = DarkNet.Instance;
        Theme processTheme = Theme.Auto;
        darkNet.SetCurrentProcessTheme(processTheme, ThemeOptions);
        Console.WriteLine($"Process theme is {processTheme}");

        Application.Run(new MainFormContainer());
    }
}