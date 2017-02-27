using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class PrinterWrapper
{
	[DllImport ("abc")]
	public static extern int PrintANumber ();

	[DllImport ("abc")]
	public static extern IntPtr PrintHello ();

	[DllImport ("abc")]
	public static extern int AddTwoIntegers (int i1, int i2);

	[DllImport ("abc")]
	public static extern float AddTwoFloats (float f1, float f2);
}
