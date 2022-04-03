using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player;
    public float speed = 10;
    private Vector3 playerPos;

    //how long we want the monster to live
    public float lifeSpan = 30;

    // Start is called before the first frame update
    void Start()
    {
        //destroys monster
        StartCoroutine(DestroyMonster());
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
    }

    //destroys monster after however many seconds we assign to lifeSpan
    IEnumerator DestroyMonster()
    {
        Debug.Log("DEATH TO MONSTER");
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }
}
