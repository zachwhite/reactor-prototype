using UnityEngine;
using System.Collections;

public class InputManager : Manager
{
#region Properties
	private Vector3 _mousePosition;
	public Vector3 MousePosition
	{
		get { return _mousePosition; }
		set { _mousePosition = value; }
	}

	private bool _mouseLeftButtonDown;
	public bool IsLeftMouseButtonDown
	{
		get { return _mouseLeftButtonDown; }
		set { _mouseLeftButtonDown = value; }
	}
#endregion


	void Update()
	{
		// Update the position of the mouse.
		MousePosition = Input.mousePosition;
	}
}
