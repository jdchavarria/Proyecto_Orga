﻿using System;
using System.Runtime.InteropServices;
public class PortAccess
{
    [DllImport("C:\\INPOUT32.DLL", EntryPoint = "Out32")]
    public static extern void Output(int adress, int value);

    [DllImport("inpout32.dll", EntryPoint = "Inp32")]
    public static extern int Input(int adress);
}