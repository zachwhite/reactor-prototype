using UnityEngine;

/// <summary>
/// Toggle between two different sprites.
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
[AddComponentMenu("Indicators/Toggle Sprite")]
public sealed class SpriteToggle : MonoBehaviour 
{
#region Constants
	public const bool OFF = false;
	public const bool ON = true;
#endregion


#region Properties
	private SpriteRenderer _spriteRenderer;

	[SerializeField]
	private bool _state = OFF;
	public bool State
	{
		get { return _state; }
		set { _state = value; updateSprite (); }
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


#region Unity Triggers
	// Runs before game starts.
	public void Awake()
	{
		_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}


	// Runs upon instantiation.
	public void Start()
	{
		updateSprite ();
	}
#endregion


	/// <summary>
	/// Toggle the sprite to its ON state.
	/// </summary>
	public void ToggleOn()
	{
		State = ON;
	}


	/// <summary>
	/// Toggle the sprite to its OFF state.
	/// </summary>
	public void ToggleOff()
	{
		State = OFF;
	}


	/// <summary>
	/// Toggle sprite to ON if it's off, to OFF if it's on.
	/// <returns>Whether the new state is ON.</returns>
	/// </summary>
	public bool Toggle()
	{
		// Toggle was on, turn it off.
		if (State == OFF)
		{
			ToggleOn ();
			return ON;
		}

		// Toggle was off, turn it on.
		ToggleOff ();
		return OFF;
	}


	// Set the sprite based on whether State is ON or OFF.
	private void updateSprite()
	{
		if (_spriteRenderer != null)
		{
			if (State == ON)
				_spriteRenderer.sprite = ToggleOnSprite;
			else
				_spriteRenderer.sprite = ToggleOffSprite;
		}
	}
}