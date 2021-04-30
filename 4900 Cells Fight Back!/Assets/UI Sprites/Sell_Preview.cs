using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell_Preview: MonoBehaviour
{
    // To be attached to the sell sprite prefab
    public Rigidbody2D rigid;
    private Vector3 mouseXY;
    private Vector2 direction;
    private Vector2 movement;
    private GameObject turret;
    private bool mouseOverTurret = false;
    private float speed = 50f;  // setting speed too high causes the sprite to glitch

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        followMouse();
        checkMouseClick();
    }

    void followMouse()
    {
        mouseXY = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mouseXY - transform.position);
        movement = new Vector2(direction.x * speed, direction.y * speed);
        rigid.velocity = movement;
    }

    private void OnTriggerStay2D(Collider2D collision) // called nonstop until another collider exits this one
    {
        if (collision.TryGetComponent<Turret_Collider>(out Turret_Collider ts))
        {
            turret = ts.gameObject.transform.parent.gameObject;
            mouseOverTurret = true;
        }
    }

    private void OnTriggerExit2D()
    {
        mouseOverTurret = false;
    }

    void checkMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (mouseOverTurret == true)    // If mouse is hovering over a turret
            {
                Destroy(turret);
                Destroy(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

}
