using UnityEngine;

[RequireComponent (typeof(Collider))]
public abstract class Clickable : MonoBehaviour
{
	public abstract void OnMouseDown();
	public abstract void OnMouseUp();
}
