using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class green : MonoBehaviour
{
    //public GameObject[] explosions;
    Rigidbody2D rigidBody;
    GameObject spawnerScript;
    spawner sp;
    // Start is called before the first frame update
    void Start()
    {
        spawnerScript = GameObject.Find("spawner");
        sp = spawnerScript.GetComponent<spawner>();
        sp.green++;
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Random.Range(1f, sp.speed), Random.Range(1f, sp.speed));
    }

    // Update is called once per frame
    void Update()
    {

    }

    /*
    public void Explode()
    {
        GameObject collision = explosions[0];
        Instantiate(collision, transform.position, transform.rotation);
        Destroy(gameObject);
    }
    */
}
