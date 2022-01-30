using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public GameObject[] explosions;
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    public int score;

    Rigidbody2D rigidBody;

    string prev = " ";

    /*
    public int destroy;
    public int minus;
    public int ball;
    */

    GameObject spawnerScript;
    spawner sp;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        rigidBody = GetComponent<Rigidbody2D>();
        /*
        destroy = 1;
        minus = 2;
        ball = 3;
        */
        spawnerScript = GameObject.Find("spawner");
        sp = spawnerScript.GetComponent<spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(up))
        {
            rigidBody.velocity = new Vector2(0f, 7f);
        }
        else if (Input.GetKey(down))
        {
            rigidBody.velocity = new Vector2(0f, -7f);
        }
        else if (Input.GetKey(left))
        {
            rigidBody.velocity = new Vector2(-7f, 0f);
        }
        else if (Input.GetKey(right))
        {
            rigidBody.velocity = new Vector2(7f, 0f);
        }
        else
        {
            rigidBody.velocity = new Vector2(0f, 0f);
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "red")
        {
            //Debug.Log("MyTag");
            if (prev == "red")
            {
                var clones = GameObject.FindGameObjectsWithTag ("red");
                foreach (var clone in clones)
                {
                    GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                    Destroy(clone);
                    Destroy(exp, 3);
                }
                clones = GameObject.FindGameObjectsWithTag ("blue");
                foreach (var clone in clones)
                {
                    GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                    Destroy(clone);
                    Destroy(exp, 3);
                }
                clones = GameObject.FindGameObjectsWithTag ("green");
                foreach (var clone in clones)
                {
                    GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                    Destroy(clone);
                    Destroy(exp, 3);
                }
            }
            else
            {
                GameObject exp = Instantiate(explosions[0], transform.position, transform.rotation);
                Destroy(col.gameObject);
                Destroy(exp, 3);
                sp.red--;
                prev = "red";
                score++;
            }
        }
        else if (col.gameObject.tag == "blue")
        {
            if (prev == "blue")
            {
              var clones = GameObject.FindGameObjectsWithTag ("red");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
              clones = GameObject.FindGameObjectsWithTag ("green");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
              clones = GameObject.FindGameObjectsWithTag ("blue");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
            }
            else
            {
                GameObject exp = Instantiate(explosions[0], transform.position, transform.rotation);
                Destroy(col.gameObject);
                Destroy(exp, 3);
                sp.blue--;
                prev = "blue";
                score++;
            }
        }
        else if (col.gameObject.tag == "green")
        {
            if (prev == "green")
            {
              var clones = GameObject.FindGameObjectsWithTag ("red");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
              clones = GameObject.FindGameObjectsWithTag ("green");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
              clones = GameObject.FindGameObjectsWithTag ("blue");
              foreach (var clone in clones)
              {
                  GameObject exp = Instantiate(explosions[0], clone.transform.position, clone.transform.rotation);
                  Destroy(clone);
                  Destroy(exp, 3);
              }
            }
            else
            {
                GameObject exp = Instantiate(explosions[0], transform.position, transform.rotation);
                Destroy(col.gameObject);
                Destroy(exp, 3);
                sp.green--;
                prev = "green";
                score++;
            }
        }
        if (score % 5 == 0)
        {
          sp.speed += 0.5f;
        }
    }
}
