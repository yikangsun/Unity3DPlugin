using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class BombWrapper
{
	[DllImport ("abc")]
	public static extern IntPtr Bomb_Create ();

	[DllImport ("abc")]
	public static extern void Bomb_SetTime (IntPtr pBomb, float time);

	[DllImport ("abc")]
	public static extern float Bomb_GetTime (IntPtr pBomb);

	[DllImport ("abc")]
	public static extern void Bomb_Delete (IntPtr pBomb);
}

