using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destroying 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Player")
        {
            Destroy(other.gameObject);
        }
        if (gameObject.CompareTag("Bad"))
        {
            spawnManager.GameOver();
        }
    }


    /** void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game over!");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }*/
}
