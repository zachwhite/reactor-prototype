using UnityEngine;

/// <summary>
/// Game Object has behavior when hovered over with the mouse.
/// </summary>
public interface IHoverable
{
	void OnMouseEnter();
	void OnMouseOver();
	void OnMouseExit();
}