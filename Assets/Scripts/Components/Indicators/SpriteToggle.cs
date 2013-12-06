using UnityEngine;
using System.Collections;

public class SpriteToggle : MonoBehaviour 
{
#region Constants
	public enum ToggleState
	{ ON = true, OFF = false }
#endregion


#region Properties
	private SpriteRenderer _spriteRenderer;

	[SerializeField] 
	private ToggleState _state;
	public ToggleState State
	{
		get { return _state; }
		set { _state = value; }
	}

	[SerializeField] 
	private Sprite _toggleOnSprite;
	public Sprite ToggleOnSprite
	{
		get { return _toggleOnSprite; }
		set { _toggleOnSprite = value; }
	}

	[SerializeField] 
	private Sprite _toggleOffSprite;
	public Sprite ToggleOffSprite
	{
		get { return _toggleOffSprite; }
		set { _toggleOffSprite = value; }
	}
#endregion


	/// <summary>
	/// Toggle the sprite to its ON state.
	/// </summary>
	public void ToggleOn()
	{
		State = ToggleState.ON;
		_spriteRenderer.sprite = ToggleOnSprite;
	}


	/// <summary>
	/// Toggle the sprite to its OFF state.
	/// </summary>
	public void ToggleOff()
	{
		State = ToggleState.OFF;
		_spriteRenderer.sprite = ToggleOffSprite;
	}


	/// <summary>
	/// Toggle sprite to ON if it's off, to OFF if it's on.
	/// <returns>Whether the new state is ON.</returns>
	/// </summary>
	public bool Toggle()
	{
		// Toggle was on, turn it off.
		if (State = ToggleState.OFF)
		{
			ToggleOn ();
			return true;
		}

		// Toggle was off, turn it on.
		ToggleOff ();
		return false;
	}
}