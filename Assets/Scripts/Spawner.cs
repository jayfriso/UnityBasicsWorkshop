using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float spawnIntervalTime;
    private float spawnTimer;
    public GameObject rotatingCube;
    public GameObject spawnIndicatorLeft;
    public GameObject spawnIndicatorRight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        spawnTimer += Time.deltaTime; //Add the current delta time of the frame to the spawn timer
        //If the spawn timer has reached the interval time, spawn a rotating cube and reset the timer
        if (spawnTimer >= spawnIntervalTime) {
            float randomRange = Random.Range(0f, 1f);
            Vector3 randomPosition = Vector3.Lerp(spawnIndicatorLeft.transform.position,
                spawnIndicatorRight.transform.position, randomRange);
            Instantiate(rotatingCube, randomPosition, Quaternion.identity);

            spawnTimer = 0;
        }
	}
}
