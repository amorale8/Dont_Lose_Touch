using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5;
    //get the play position
    private GameObject playerTransform;

    //how long we want the monster to live
    public float lifeSpan = 60;

    // Start is called before the first frame update
    void Start()
    {
        //destroys monster
        StartCoroutine(DestroyMonster());
        rb = GetComponent<Rigidbody>();
        playerTransform = GameObject.Find("VanillaPlayer");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.transform.position, speed * Time.deltaTime);
    }

    //destroys monster after however many seconds we assign to lifeSpan
    IEnumerator DestroyMonster()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        // need to make it so it "kills" the player going to gameover

    }
}
