using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eosinophil_Proj : MonoBehaviour
{
    public float speed = 2;
    //public Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        //rigid = GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
