using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour
{
    [SerializeField]
    private SceneController controller;

    private int _id;
    public int id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    [SerializeField]
    private GameObject cardBack;

    public void OnMouseDown()
    {
        Debug.Log("mouse down");

        if (cardBack.activeSelf && controller.canReveal)
        {
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }
}
