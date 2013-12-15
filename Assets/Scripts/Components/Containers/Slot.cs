using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public abstract class Slot : MonoBehaviour 
{
#region Constants
	public enum ContentTypes { EMPTY, BLOCKED, ITEM }
#endregion

#region Properties
	protected SpriteRenderer _spriteRenderer;

	private Sprite _icon;
	public Sprite Icon
	{
		get { return _icon; }
		set 
		{ 
			_icon = value;
			_spriteRenderer.sprite = _icon;
		}
	}
	
	private ContentTypes _containsType = ContentTypes.EMPTY;
	public ContentTypes ContainsType
	{
		get { return _containsType; }
		set { _containsType = value; }
	}

#endregion

	public virtual void Awake()
	{
		_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		
		// Most slots are clickable. Check they have a Collider2D component.
		if (gameObject.ImplementsInterface<IClickable>())
		{
			if (gameObject.GetComponent<Collider2D>() == null)
				Debug.LogWarning ("Clickable slot has no Collider2D Component!");
		}
	}
}
