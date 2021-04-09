using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Turret : MonoBehaviour
{
    public GameObject antibody_proj;
    private GameObject proj;
    public Transform shotspawn;
    private float cooldown = 0.05f;
    public float cooldownRemain;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void Fire()
    {                       // Define max spread here
        float spread = Random.Range(-5, 5);
        Quaternion spreadRotation = Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z + spread));

        if (cooldownRemain <= 0)
        {
            proj = Instantiate(antibody_proj, shotspawn.position, spreadRotation) as GameObject;
            // Version below has no spread implemented
            //instance = Instantiate(antibody_proj, shotspawn.position, transform.rotation) as GameObject;
            cooldownRemain = cooldown;
        }
        else
        {
            cooldownRemain -= Time.deltaTime;
        }
                
    }

}
