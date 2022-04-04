using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    /// <summary>
    /// I want to make it so that it can only spawn one monster 
    /// at a time but I don't know how to yet
    /// </summary>
    public GameObject monsterPrefab;

    //this will be changed to the spawn points (gameobject)
    private Vector3 spawnPos = new Vector3(5, 1, 0);

    public float startDelay= 1;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnMonster", startDelay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnMonster()
    {
        Instantiate(monsterPrefab, spawnPos, monsterPrefab.transform.rotation);
    }
}
