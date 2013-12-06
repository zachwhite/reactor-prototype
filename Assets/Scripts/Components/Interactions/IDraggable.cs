using UnityEngine;

/// <summary>
/// Game Object can be dragged with the mouse.
/// </summary>
public interface IDraggable
{
	void OnMouseDrag();
	void OnMouseUp();
}
