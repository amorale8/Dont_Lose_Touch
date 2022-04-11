using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject itemPrefab;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            Instantiate(itemPrefab, transform.position, itemPrefab.transform.rotation);
            counter++;
            if (counter == 5)
            {
                TurnOff();
            }
        }
    }

    public void TurnOff()
    {
        this.enabled = false;
    }
}
