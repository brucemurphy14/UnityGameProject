using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    private SpawnManager spawnManager;
    private AudioSource gameAudio;
    public AudioClip fruitSound;
    public AudioClip rockSound;


    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("Spawn Manager").GetComponent<SpawnManager>();
        gameAudio = GetComponent<AudioSource>();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Destroying 
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fruit"))
        {
            gameAudio.PlayOneShot(fruitSound, 1.0f);
            Destroy(other.gameObject);
        }
        else if (gameObject.CompareTag("Bad"))
        {
            gameAudio.PlayOneShot(rockSound, 1.0f);
            spawnManager.GameOver();
            GameObject[] rockDestroyer = GameObject.FindGameObjectsWithTag("Bad");
            foreach(GameObject rock in rockDestroyer)
            {
                Destroy(rock);
            }
            GameObject[] fruitDestroyer = GameObject.FindGameObjectsWithTag("Fruit");
            foreach (GameObject fruit in fruitDestroyer)
            {
                Destroy(fruit);
            }
        }
    }


    /** void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game over!");
        Destroy(gameObject);
        Destroy(other.gameObject);
    }*/
}
