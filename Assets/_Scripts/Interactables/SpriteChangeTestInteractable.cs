using UnityEngine;

public class SpriteChangeTestInteractable : MonoBehaviour
{
    public Sprite spritChange;
    private SpriteRenderer _sr;

    private void Start()
    {
        _sr = GetComponentInChildren<SpriteRenderer>();
    }

    public void ChangeSprite()
    {
        _sr.sprite = spritChange;
    }
}
