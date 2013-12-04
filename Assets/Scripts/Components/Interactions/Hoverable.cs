using UnityEngine;

[RequireComponent (typeof(Collider))]
public abstract class Hoverable : MonoBehaviour
{
	public abstract void OnMouseEnter();
	public abstract void OnMouseOver();
	public abstract void OnMouseExit();
}