using UnityEngine;
using System.Collections;

[RequireComponent (typeof(SpriteRenderer))]
public class Slot : MonoBehaviour 
{
#region Fields
	[SerializeField] private Sprite[] _spriteLibrary;

	private SpriteRenderer _spriteRenderer;
#endregion


#region Properties
	public Sprite[] SpriteLibrary
	{
		get { return _spriteLibrary; }
		set { _spriteLibrary = value; }
	}
#endregion

	void Start()
	{
		_spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
	}


	public virtual void SetActiveIcon(int spriteIndex)
	{
		_spriteRenderer.sprite = SpriteLibrary[spriteIndex];
	}
}
