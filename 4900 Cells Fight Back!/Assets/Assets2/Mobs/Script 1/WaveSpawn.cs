using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawn : MonoBehaviour
{
    public Wave[] waves;

	public Transform spawnPoint;
	public float timeBetweenWaves = 5f;
	private float countdown = 2f;
	
	private int wavetimer = 0;
	void Update ()

	{
		if (countdown <= 0f)
		{
		StartCoroutine(SpawnWave());
		countdown = timeBetweenWaves;
		}			
	countdown -= Time.deltaTime;
	}

	IEnumerator SpawnWave()
	{
	Wave wave = waves[wavetimer];
	for (int i = 0; i < wave.count; i++)
	{
		SpawnEnemy(wave.enemy);
		yield return new WaitForSeconds(1f / wave.rate);
	}
	wavetimer++;

	if (wavetimer == waves.Length)
	{
		Debug.Log("Level Done!");
		this.enabled = false;
	}
}

	void SpawnEnemy (GameObject enemy)
	{
	Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
}

}
