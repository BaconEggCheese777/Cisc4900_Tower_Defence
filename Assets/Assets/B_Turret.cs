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



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        FindTargetAndFire();


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

    void haltFire()
    {
        Audio.Stop();
        audioPlaying = false;
        animator.SetBool("isFiring", false);
    }

    void FindTargetAndFire()
    {
        if (gameObject.TryGetComponent<Target_Selector>(out Target_Selector targeter))
        {
            if (targeter.isFiring == true)
            {
                Fire();
            }
            else
            {
                haltFire();
            }
        }
    }

}
