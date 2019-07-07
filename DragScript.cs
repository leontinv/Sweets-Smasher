using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragScript : MonoBehaviour
{
    private bool press;
    public Rigidbody2D ballRigidBody;
    Vector2 startPos, endPos, direction;
    void Update()
    {
        if (press == true)
        {
            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(cursorPos.x, cursorPos.y);
            Debug.Log(transform.position);
        }
        if(Input.GetMouseButtonUp(0))
        {
            endPos = transform.position;
            direction = endPos - startPos;
            ballRigidBody.AddForce(direction/2f * 5f);
            press = false;
            ballRigidBody.isKinematic = false;
        }
    }

    void OnMouseOver()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = transform.position;
            press = true;
        }
    }
}
