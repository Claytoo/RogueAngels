using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private SpriteRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        float mouseX = (Screen.width / 2) - Input.mousePosition.x;
        if (mouseX < 0)
        {
            _renderer.flipX = false;
        }
        else
        {
            _renderer.flipX = true;
        }
    }
}
