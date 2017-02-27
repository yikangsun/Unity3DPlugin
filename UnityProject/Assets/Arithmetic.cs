using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

namespace Math
{
	public class Arithmetic
	{
		[DllImport ("Arithmetic", EntryPoint = "addition", CallingConvention = CallingConvention.Cdecl)]
		public static extern float addition (float val_1, float val_2);

		[DllImport ("Arithmetic", EntryPoint = "substraction", CallingConvention = CallingConvention.Cdecl)]
		public static extern float substraction (float val_1, float val_2);

		[DllImport ("Arithmetic", EntryPoint = "multiplication", CallingConvention = CallingConvention.Cdecl)]
		public static extern float multiplication (float val_1, float val_2);

		[DllImport ("Arithmetic", EntryPoint = "division", CallingConvention = CallingConvention.Cdecl)]
		public static extern float division (float val_1, float val_2);
	}
}

