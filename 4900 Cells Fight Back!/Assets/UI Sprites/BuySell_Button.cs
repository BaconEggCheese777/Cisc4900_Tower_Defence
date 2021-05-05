using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuySell_Button : MonoBehaviour
{
    public GameObject moneysign;
    public GameObject turret1;
    public GameObject turret2;
    public GameObject turret3;
    public GameObject turret4;
    public GameObject turret5;

    public GameObject boneWithSpots;
    private int turretSpotCount = 1;

    private Transform mouseXY;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnSellPreview()
    {
        Instantiate(moneysign, Input.mousePosition, transform.rotation);
    }

    public void spawnTurretPreview1()
    {
        Instantiate(turret1, Input.mousePosition, transform.rotation);
        transform.parent.gameObject.SetActive(false);
    }

    public void spawnTurretPreview2()
    {
        Instantiate(turret2, Input.mousePosition, transform.rotation);
        transform.parent.gameObject.SetActive(false);
    }

    public void spawnTurretPreview3()
    {
        Instantiate(turret3, Input.mousePosition, transform.rotation);
        transform.parent.gameObject.SetActive(false);
    }

    public void spawnTurretPreview4()
    {
        Instantiate(turret4, Input.mousePosition, transform.rotation);
        transform.parent.gameObject.SetActive(false);
    }

    public void spawnTurretPreview5()
    {
        Instantiate(turret5, Input.mousePosition, transform.rotation);
        transform.parent.gameObject.SetActive(false);
    }

    public void buyTurretSpot()
    {   
        switch(turretSpotCount)     // based on how many turret spots the player has already
        {
            case 1:
                boneWithSpots.transform.GetChild(2).gameObject.SetActive(true);
                turretSpotCount++;
                break;
            case 2:
                boneWithSpots.transform.GetChild(1).gameObject.SetActive(true);
                turretSpotCount++;
                break;
            case 3:
                boneWithSpots.transform.GetChild(0).gameObject.SetActive(true);
                turretSpotCount++;
                break;
        }
        
    }
}
