using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveLeft : MonoBehaviour
{
	private float speed = 0.5f;
    private float speedMod;
    private float slowCountdown = 0;
	public bool MoveLeft;
    private int hp = 1000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if (slowCountdown <= 0)     // no slows applied
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speedMod, 0, 0);
        }
        slowCountdown -= Time.deltaTime;

    }

    public void damageEnemy(int damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void slow(float slowAmount, float slowDuration)
    {
        speedMod = speed * slowAmount;
        slowCountdown = slowDuration;
    }
}
