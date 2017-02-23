using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class PluginImport : MonoBehaviour
{
	//Lets make our calls from the Plugin
	[DllImport ("abc")]
	private static extern int PrintANumber ();

	[DllImport ("abc")]
	private static extern IntPtr PrintHello ();

	[DllImport ("abc")]
	private static extern int AddTwoIntegers (int i1, int i2);

	[DllImport ("abc")]
	private static extern float AddTwoFloats (float f1, float f2);

	void Start ()
	{
		Debug.Log (PrintANumber ());
		Debug.Log (Marshal.PtrToStringAuto (PrintHello ()));
		Debug.Log (AddTwoIntegers (2, 2));
		Debug.Log (AddTwoFloats (2.5F, 4F));
	}
}