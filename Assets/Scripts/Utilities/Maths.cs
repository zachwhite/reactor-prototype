using UnityEngine;
using System;

namespace MonoConcept { namespace Utilities {
public sealed class Maths
{
	/// <summary>
	/// Return the cube root of a number.
	/// </summary>
	/// <returns>The cube root of x</returns>
	/// <param name="x">Number to calculate the cube root of.</param>
	public static float CubicRoot(float x)
	{
		return Mathf.Pow(x, (1.0f / 3.0f));
	}
}}}