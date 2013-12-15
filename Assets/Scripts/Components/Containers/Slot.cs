using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public abstract class Slot : MonoBehaviour 
{
#region Properties
	protected SpriteRenderer _spriteRenderer;

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

	public virtual void Awake()
	{
		_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
}
