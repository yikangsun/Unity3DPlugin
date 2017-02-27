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
			Debug.Log ("\n--------------Testing Calculator Start--------------");
			Debug.Log (ArithmeticWrapper.addition (5.0f, 4.0f));
			Debug.Log (ArithmeticWrapper.substraction (10, 3));
			Debug.Log (ArithmeticWrapper.multiplication (2, 5));
			Debug.Log (ArithmeticWrapper.division (10, 2));
			Debug.Log ("End");

			Debug.Log ("\n--------------Testing Printer Start--------------");
			Debug.Log (PrinterWrapper.PrintANumber ());
			Debug.Log (Marshal.PtrToStringAuto (PrinterWrapper.PrintHello ()));
			Debug.Log (PrinterWrapper.AddTwoIntegers (2, 2));
			Debug.Log (PrinterWrapper.AddTwoFloats (2.5F, 4F));
			Debug.Log ("End");

			Debug.Log ("\n--------------Testing Bomb Start--------------");
			Debug.Log ("bomb has been created");
			IntPtr oneBomb = BombWrapper.Bomb_Create ();
			BombWrapper.Bomb_SetTime (oneBomb, 100.0f);
			float time = BombWrapper.Bomb_GetTime (oneBomb);
			Debug.Log ("bomb time current is set to " + time);
			BombWrapper.Bomb_Delete (oneBomb);
			Debug.Log ("bomb has been deleted");
			Debug.Log ("End");
		}
	}
}

