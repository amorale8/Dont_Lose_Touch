using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject player;
    public float speed = 10;

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
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }

    //destroys monster after however many seconds we assign to lifeSpan
    IEnumerator DestroyMonster()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }
}
