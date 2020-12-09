using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spauner : MonoBehaviour {
    public GameObject cubePrefab;
    public Vector3 speedCube;
    public float lifeDistance;
    public float period;
    private float currentTime = 0;

	// Use this for initialization
	void Start () {
        currentTime = period;
    }

    IEnumerator liveBox(Vector3 spawnPosition, Vector3 speed, float distance)
    {
        GameObject cube = Instantiate(cubePrefab);
        float speedLength = speed.magnitude;
        cube.transform.position = spawnPosition;
        for (float distancePassed = 0; distancePassed < distance; distancePassed += Time.deltaTime * speedLength)
        {
            cube.transform.position += Time.deltaTime * speed;
            yield return null;
        }
        Destroy(cube);
    }
	
	// Update is called once per frame
	void Update () {
        if (currentTime < period)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            StartCoroutine(liveBox(transform.position, speedCube, lifeDistance));
            currentTime = 0;
        }
    }
    

}
