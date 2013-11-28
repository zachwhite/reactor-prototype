using UnityEngine;
using System.Collections;

/// <summary>
/// Interface for any object that can be stored.
/// </summary>
public interface IStorable
{
	string Name { get; set; }
	Sprite Icon { get; set; }

}
