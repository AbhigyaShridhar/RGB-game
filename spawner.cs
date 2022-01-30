using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] reds;
    public GameObject[] blues;
    public GameObject[] greens;

    public float speed;

    public int red;
    public int blue;
    public int green;

    GameObject playerScript;
    player p;

    // Start is called before the first frame update
    void Start()
    {
        red = 1;
        blue = 1;
        green = 1;
        playerScript = GameObject.Find("Player");
        p = playerScript.GetComponent<player>();
        speed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
      /*
        if (Input.GetMouseButtonDown(0))
        {
          int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
          Vector3 pos = spawnPoints[randomSpawnPoint].position;
          pos.z = 0;
          if (p.ball is 1)
          {
            Instantiate(reds[0], pos, transform.rotation);
          }
          else if (p.ball is 2)
          {
            Instantiate(greens[0], pos, transform.rotation);
          }
          else
          {
            Instantiate(blues[0], pos, transform.rotation);
          }
        }
        */

        if (red is 0)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            Vector3 pos1 = spawnPoints[randomSpawnPoint].position;
            pos1.z = 0;
            /*
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            Vector3 pos2 = spawnPoints[randomSpawnPoint].position;
            pos2.z = 0;
            */
            GameObject R = Instantiate(reds[0], pos1, transform.rotation);
            //Instantiate(greens[0], pos2, transform.rotation);
        }
        else if (green is 0)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            Vector3 pos1 = spawnPoints[randomSpawnPoint].position;
            pos1.z = 0;
            GameObject G = Instantiate(greens[0], pos1, transform.rotation);
        }
        else if (blue is 0)
        {
            int randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            Vector3 pos1 = spawnPoints[randomSpawnPoint].position;
            pos1.z = 0;
            GameObject B = Instantiate(blues[0], pos1, transform.rotation);
        }
    }
}
