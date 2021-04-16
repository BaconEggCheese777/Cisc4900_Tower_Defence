using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class T_Projectile : MonoBehaviour
{
    public float speed = 2000;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
