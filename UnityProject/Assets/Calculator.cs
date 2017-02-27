using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

namespace App
{
	public class Calculator : MonoBehaviour
	{
		void Start ()
		{
			Debug.Log ("\nTesting Calculator Start");
			Debug.Log (ArithmeticWrapper.addition (5.0f, 4.0f));
			Debug.Log (ArithmeticWrapper.substraction (10, 3));
			Debug.Log (ArithmeticWrapper.multiplication (2, 5));
			Debug.Log (ArithmeticWrapper.division (10, 2));
			Debug.Log ("Testing Calculator End");


			Debug.Log ("\nTesting Printer Start");
			Debug.Log (PrinterWrapper.PrintANumber ());
			Debug.Log (Marshal.PtrToStringAuto (PrinterWrapper.PrintHello ()));
			Debug.Log (PrinterWrapper.AddTwoIntegers (2, 2));
			Debug.Log (PrinterWrapper.AddTwoFloats (2.5F, 4F));
			Debug.Log ("Testing Printer End");
		}
	}
}

