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
	private float _progressBarPercent = FULL;
	public float ProgressBarPercent 
	{ 
		get { return _progressBarPercent; }
		set  
		{ 
			if (value > FULL)
				value = FULL;
			else if (value < EMPTY)
				value = EMPTY;
			_progressBarPercent = value;
		}
	}

	[SerializeField] 
	private ProgressBarType _barType = ProgressBarType.HORIZONTAL;
	public ProgressBarType BarType
	{
		get { return _barType; }
		set { _barType = value; }
	}

	[SerializeField] 
	private bool _tintColor = false;
	public bool TintColor
	{
		get { return _tintColor; }
		set { _tintColor = value; }
	}

	[SerializeField] 
	private Color _progressBarColorCritical = new Color(1f, 0f, 0f);
	private Color ProgressBarColorCritical
	{ 
		get { return _progressBarColorCritical; }
		set { _progressBarColorCritical = value; }
	}

	[SerializeField] 
	private Color _progressBarColorLow = new Color(1f, 0.5f, 0f);
	private Color ProgressBarColorLow
	{
		get { return _progressBarColorLow; }
		set { _progressBarColorLow = value; }
	}

	[SerializeField] 
	private Color _progressBarColorMedium = new Color(1f, 1f, 0f);
	private Color ProgressBarColorMedium
	{
		get { return _progressBarColorMedium; }
		set { _progressBarColorMedium = value; }
	}

	[SerializeField] 
	private Color _progressBarColorHigh = new Color(0f, 1f, 0f);
	private Color ProgressBarColorHigh
	{
		get { return _progressBarColorHigh; }
		set { _progressBarColorHigh = value; }
	}
#endregion


	public void Awake()
	{
		ProgressBarSprite = gameObject.GetComponent<SpriteRenderer>().sprite;
		ProgressBarWidth = ProgressBarSprite.rect.width;
		ProgressBarHeight = ProgressBarSprite.rect.height;
	}
}