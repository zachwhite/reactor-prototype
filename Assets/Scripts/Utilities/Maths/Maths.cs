using UnityEngine;
using System;

namespace MonoConcept { namespace Utilities { namespace Maths {

/// <summary>
/// Math utilities.
/// </summary>
public sealed class Maths
{
	/// <summary>
	/// Returns the cube root of a number.
	/// </summary>
	/// <returns>The cube root of x.</returns>
	/// <param name="x">The number to calculate the cube root of.</param>
	public static double CubicRoot(double x)
	{
		return (double) Mathf.Pow((float) x, (1.0f / 3.0f));
	}
	
	
	/// <summary>
	/// Return the Greatest Common Divisor of two numbers.
	/// </summary>
	/// <param name="x">First integer to compare.</param>
	/// <param name="y">Second integer to compare.</param>
	public static double GreatestCommonDivisor(double x, double y)
	{
		x = Math.Abs (x); y = Math.Abs (y);
		double z;
		
		while (y != 0)
		{
			z = x % y;
			x = y;
			y = z;
		}
		
		return x;
	}
	
	
	/// <summary>
	/// Return the Greatest Common Divisor of two numbers.
	/// </summary>
	/// <param name="x">An array of integers.</param>
	public static double GreatestCommonDivisor(double[] x)
	{
		double result = 0;
		
		for (int i = 0; i < x.Length; i++)
		{
			result = GreatestCommonDivisor(x[i], result);
		}
		
		return result;
	}
	
	
	/// <summary>
	/// Return the Greatest Common Denominator of two numbers.
	/// Uses Euclidian Algorithm.
	/// </summary>
	/// <param name="x">First integer to compare.</param>
	/// <param name="y">Second integer to compare.</param>
	public static double GreatestCommonDenominator(double x, double y)
	{
		while (x != 0 && y != 0)
		{
			if (x > y)
				x %= y;
			else
				y %= x;
		}
		
		if (x == 0)
			return y;
		else
			return x;
	}
	
	
	/// <summary>
	/// Return the Greatest Common Denominator of a range of numbers.
	/// Uses Euclidian Algorithm.
	/// </summary>
	/// <param name="x">An array of integers.</param>
	public static double GreatestCommonDenominator(double[] x)
	{
		double result = 0;
		
		for (int i = 0; i < x.Length; i++)
		{
			result = GreatestCommonDenominator(x[i], result);
		}
		
		return result;
	}
	
	
	
	
	
	
}
}}}