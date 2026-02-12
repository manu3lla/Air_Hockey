using UnityEngine;

public class NewEmptyCSharpScript
{
    bool wasJustClicked = true;
    bool canMove;
    Vector2 playerSize;
    void Start
    {
        playerSize = gameObject.getComponent<SpriteRenderer>().bounds.extents;
    }
    void Update
    {
        if (input.GetMouseButton(0)){
            Vector2 mousePos = Camera.main.screenToWorldPoint(Input.mousePosition);
            if (wasJustClicked)
            {
                wasJustClicked = false;
                if ((mousePos.x >= transform.position.x && mousePos.x < transform.position.x + playerSize.x ||
     mousePos.x <= transform.position.x && mousePos.x > transform.position.x - playerSize.x) &&
    (mousePos.y >= transform.position.y && mousePos.y < transform.position.y + playerSize.y ||
     mousePos.y <= transform.position.y && mousePos.y > transform.position.y - playerSize.y))
                {
                    canMove = true;
                }
                else
                {
                    canMove = false;
                }
            if (canMove)
                {
                    transform.position = mousePos;
                }
            }
            else
            {
                wasJustClicked= true;
            }
        }

    }
    
}
