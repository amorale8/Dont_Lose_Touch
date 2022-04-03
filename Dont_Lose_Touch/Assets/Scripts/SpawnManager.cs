using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject monsterPrefab;

    //change to a range or specific points later one
    //could assign to an assest in game 
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
