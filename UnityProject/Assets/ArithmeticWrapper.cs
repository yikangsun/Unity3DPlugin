using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class ArithmeticWrapper
{
	[DllImport ("abc")]
	public static extern float addition (float val_1, float val_2);

	[DllImport ("abc")]
	public static extern float substraction (float val_1, float val_2);

	[DllImport ("abc")]
	public static extern float multiplication (float val_1, float val_2);

	[DllImport ("abc")]
	public static extern float division (float val_1, float val_2);
}

