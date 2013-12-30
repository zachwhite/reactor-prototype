using UnityEngine;
using System.Collections;

public class InputManager : Manager
{
#region Properties
	private Vector3 _MousePosition;
	public Vector3 MousePosition
	{
		get { return _MousePosition; }
		set { _MousePosition = value; }
	}

	private bool _MouseLeftButtonDown;
	public bool IsLeftMouseButtonDown
	{
		get { return _MouseLeftButtonDown; }
		set { _MouseLeftButtonDown = value; }
	}
#endregion


	void Update()
	{
		// Update the position of the mouse.
		MousePosition = Input.mousePosition;
	}
}
