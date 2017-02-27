using System;
using UnityEngine;
using Math;

namespace App
{
	public class Calculator : MonoBehaviour
	{
		void Start ()
		{
			Debug.Log (Arithmetic.addition (5, 5));
			Debug.Log (Arithmetic.substraction (10, 5));
			Debug.Log (Arithmetic.multiplication (2, 5));
			Debug.Log (Arithmetic.division (10, 2));
		}
	}
}

