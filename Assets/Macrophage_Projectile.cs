using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Macrophage_Projectile : MonoBehaviour
{
    public float speed = 5;
    private float size = 3f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 20.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        GrowAccelerate();
    }

    void GrowAccelerate()
    {
        size += 0.01f;
        speed += 0.01f;
        transform.localScale = new Vector2(size, size);
    }

    // Add collider method. If true, modify speed to 1
}
