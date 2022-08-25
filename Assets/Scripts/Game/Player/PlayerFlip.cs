using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    void Update()
    {
        float mouseX = (Screen.width / 2) - Input.mousePosition.x;
        if (mouseX < 0)
        {
            transform.parent.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            transform.parent.localScale = new Vector3(-1, 1, 1);
        }
    }
}
