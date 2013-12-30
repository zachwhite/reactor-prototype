using UnityEngine;
using UnityEditor;
using System.Collections;

/// <summary>
/// Turns a sprite into a progress bar that grows/shrinks in proportion.
/// </summary>
[RequireComponent(typeof(SpriteRenderer))]
[AddComponentMenu("Indicators/Progress Bar")]
public class ProgressBar : MonoBehaviour 
{
#region Constants
	public enum ProgressBarType
	{ HORIZONTAL, VERTICAL }
	
	private const float EMPTY = 0f;
	private const float FULL = 100f;
#endregion


#region Properties
	private Sprite ProgressBarSprite { get; set; }
	private Color ProgressBarActiveColor { get; set; }
	private float ProgressBarWidth { get; set; }
	private float ProgressBarHeight { get; set; }

	[SerializeField]
	private float _ProgressBarPercent = FULL;
	public float ProgressBarPercent 
	{ 
		get { return _ProgressBarPercent; }
		set  
		{ 
			if (value > FULL)
				value = FULL;
			else if (value < EMPTY)
				value = EMPTY;
			_ProgressBarPercent = value;
		}
	}

	[SerializeField] 
	private ProgressBarType _BarType = ProgressBarType.HORIZONTAL;
	public ProgressBarType BarType
	{
		get { return _BarType; }
		set { _BarType = value; }
	}

	[SerializeField] 
	private bool _TintColor = false;
	public bool TintColor
	{
		get { return _TintColor; }
		set { _TintColor = value; }
	}

	[SerializeField] 
	private Color _ProgressBarColorCritical = new Color(1f, 0f, 0f);
	private Color ProgressBarColorCritical
	{ 
		get { return _ProgressBarColorCritical; }
		set { _ProgressBarColorCritical = value; }
	}

	[SerializeField] 
	private Color _ProgressBarColorLow = new Color(1f, 0.5f, 0f);
	private Color ProgressBarColorLow
	{
		get { return _ProgressBarColorLow; }
		set { _ProgressBarColorLow = value; }
	}

	[SerializeField] 
	private Color _ProgressBarColorMedium = new Color(1f, 1f, 0f);
	private Color ProgressBarColorMedium
	{
		get { return _ProgressBarColorMedium; }
		set { _ProgressBarColorMedium = value; }
	}

	[SerializeField] 
	private Color _ProgressBarColorHigh = new Color(0f, 1f, 0f);
	private Color ProgressBarColorHigh
	{
		get { return _ProgressBarColorHigh; }
		set { _ProgressBarColorHigh = value; }
	}
#endregion


	public void Awake()
	{
		ProgressBarSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
		ProgressBarWidth = ProgressBarSprite.rect.width;
		ProgressBarHeight = ProgressBarSprite.rect.height;
	}
}