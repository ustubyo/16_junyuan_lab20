﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscripts : MonoBehaviour
{
    public GameObject WallPrefab;

    public float spawnInterval;


    //Spawn area
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitAndSpawn(spawnInterval));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator WaitAndSpawn(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Vector2 spawnPosition = new Vector3(Random.Range(minX, maxX), 0.5f, Random.Range(minZ, maxZ));
            Instantiate(WallPrefab, spawnPosition, Quaternion.identity);
        }
    }
}
