using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Preview : MonoBehaviour
{    
    // To be attached to the turret preview prefabs

    public Rigidbody2D rigid;
    private Vector3 mouseXY;
    private Vector2 direction;
    private Vector2 movement;
    private GameObject turretSpot;
    private bool mouseOverTurretSpot = false;
    private float speed = 50f;

    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;
    public GameObject turret4;
    public GameObject turret5;

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

    // Create a method that spawns a turret on click based on this preview's name. Fetch the name
    //       with gameObject.name


    void followMouse()
    {
        mouseXY = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mouseXY - transform.position);
        movement = new Vector2(direction.x * speed, direction.y * speed);
        rigid.velocity = movement;
    }
    private void OnTriggerStay2D(Collider2D collision) // called nonstop until another collider exits this one
    {
        if (collision.TryGetComponent<Turret_Spot>(out Turret_Spot ts))
        {
            turretSpot = ts.gameObject;
            mouseOverTurretSpot = true;
        }
    }

    private void OnTriggerExit2D()
    {
        mouseOverTurretSpot = false;
    }

    void checkMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (mouseOverTurretSpot == true)    // If mouse is hovering over a turret
            {
                Debug.Log("Found Turret Spot!");
                Destroy(gameObject);
                spawnTurret(gameObject.name);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    void spawnTurret(string name)
    {
        switch(name)
        {
            case "Tower_Preview1(Clone)":
                Debug.Log("Turret 1");
                Instantiate(turret1, turretSpot.transform.position, transform.rotation);
                break;
            case "Tower_Preview2(Clone)":
                Debug.Log("Turret 2");
                Instantiate(turret2, turretSpot.transform.position, transform.rotation);
                break;
            case "Tower_Preview3(Clone)":
                Debug.Log("Turret 3");
                Instantiate(turret3, turretSpot.transform.position, transform.rotation);
                break;
            case "Tower_Preview4(Clone)":
                Debug.Log("Turret 4");
                Instantiate(turret4, turretSpot.transform.position, transform.rotation);
                break;
            case "Tower_Preview5(Clone)":
                Debug.Log("Turret 5");
                Instantiate(turret5, turretSpot.transform.position, transform.rotation);
                break;
        }
    }
}
