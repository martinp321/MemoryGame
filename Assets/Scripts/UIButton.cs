using UnityEngine;
using System.Collections;

public class UIButton : MonoBehaviour {

	[SerializeField]
	private GameObject targetObject;

	[SerializeField]
	private string targetMessage;

	public Color highlightColor = Color.cyan;

   public void setColor(Color color)
	{
		SpriteRenderer sprite = GetComponent<SpriteRenderer>();
		if (sprite != null)
		{
			sprite.color = color;
		}
	}
	public void OnMouseOver()
	{
		setColor(highlightColor);
	}

	public void OnMouseExit()
	{
		setColor(Color.white);
	}

    public void OnMouseUp()
    {
        if (targetObject != null)
        {
            targetObject.SendMessage(targetMessage);
        }
    }


}
