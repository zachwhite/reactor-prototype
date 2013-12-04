using UnityEngine;

[RequireComponent (typeof(Collider))]
public abstract class Draggable : MonoBehaviour
{
	public abstract void OnMouseDrag();
	public abstract void OnMouseUp();
}
