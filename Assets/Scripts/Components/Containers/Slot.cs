using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public abstract class Slot : MonoBehaviour 
{
#region Constants
	public enum ContentTypes { EMPTY, BLOCKED, ITEM }
#endregion

#region Properties
	protected SpriteRenderer _SpriteRenderer;

	private Sprite _Icon;
	public Sprite Icon
	{
		get { return _Icon; }
		set 
		{ 
			_Icon = value;
			_SpriteRenderer.sprite = _Icon;
		}
	}
	
	private ContentTypes _ContainsType = ContentTypes.EMPTY;
	public ContentTypes ContainsType
	{
		get { return _ContainsType; }
		set { _ContainsType = value; }
	}

#endregion

	public virtual void Awake()
	{
		_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
		
		// Most slots are clickable. Check they have a Collider2D component.
		if (gameObject.ImplementsInterface<IClickable>())
		{
			if (gameObject.GetComponent<Collider2D>() == null)
				Debug.LogWarning ("Clickable slot has no Collider2D Component!");
		}
	}
}
