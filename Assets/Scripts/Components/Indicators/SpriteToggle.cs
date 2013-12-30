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
	private SpriteRenderer _SpriteRenderer;

	[SerializeField]
	private bool _State = OFF;
	public bool State
	{
		get { return _State; }
		set { _State = value; UpdateSprite (); }
	}

	[SerializeField] 
	private Sprite _ToggleOnSprite;
	public Sprite ToggleOnSprite
	{
		get { return _ToggleOnSprite; }
		set { _ToggleOnSprite = value; }
	}

	[SerializeField] 
	private Sprite _ToggleOffSprite;
	public Sprite ToggleOffSprite
	{
		get { return _ToggleOffSprite; }
		set { _ToggleOffSprite = value; }
	}
#endregion


#region Unity Triggers
	// Runs before game starts.
	public void Awake()
	{
		_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}


	// Runs upon instantiation.
	public void Start()
	{
		UpdateSprite ();
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
	private void UpdateSprite()
	{
		if (_SpriteRenderer != null)
		{
			if (State == ON)
				_SpriteRenderer.sprite = ToggleOnSprite;
			else
				_SpriteRenderer.sprite = ToggleOffSprite;
		}
	}
}