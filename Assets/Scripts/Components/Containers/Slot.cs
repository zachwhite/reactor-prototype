using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public class Slot : MonoBehaviour 
{
#region Properties
	private SpriteRenderer _spriteRenderer;

	[SerializeField] private Sprite _icon;
	public Sprite Icon
	{
		get { return _icon; }
		set 
		{ 
			_icon = value;
			_spriteRenderer.sprite = _icon;
		}
	}

#endregion

	void Start()
	{
		_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
}
