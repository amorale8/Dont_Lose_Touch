using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    /// <summary>
    /// need to get this script to find the player and see 
    /// which spawn point it is closes to and then have
    /// it run the spawnManager code to spawn a monster
    /// </summary>
    
    public GameObject spwnMana;
    public SpawnManager spawnMan;

    // Start is called before the first frame update
    void Start()
    {
        //getting the script from SpawnManager
        spawnMan = spwnMana.GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
