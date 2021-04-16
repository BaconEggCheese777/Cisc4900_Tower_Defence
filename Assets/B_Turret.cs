using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Turret : MonoBehaviour
{
    public GameObject antibody_proj;
    private GameObject proj;
    public Transform shotspawn;
    private float cooldown = 0.05f;
    private float cooldownRemain;
    public Animator animator;
    public AudioSource Audio;
    private bool audioPlaying =  false;

    private bool startDemo = false;  // delete after demo


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitaBit());
    }

    // Update is called once per frame
    void Update()
    {   
        // delete after demo
        if (startDemo == true)
        {
            Fire();
        }
        
        
    }

    void Fire()
    {                       // Define max spread here
        float spread = Random.Range(-5, 5);
        Quaternion spreadRotation = Quaternion.Euler(new Vector3(0, 0, transform.localEulerAngles.z + spread));

        if (audioPlaying == false)
        {
            Audio.Play();
            audioPlaying = true;
        }

        animator.SetBool("isFiring", true);

        if (cooldownRemain <= 0)
        {
            proj = Instantiate(antibody_proj, shotspawn.position, spreadRotation) as GameObject;
            cooldownRemain = cooldown;
        }
        else
        {
            cooldownRemain -= Time.deltaTime;
        }
                
    }

    // This function will be deleted after demo.
    IEnumerator WaitaBit()
    {
        yield return new WaitForSeconds(3);
        startDemo = true;
    }

    // collision method should set animator isFiring to false

}
