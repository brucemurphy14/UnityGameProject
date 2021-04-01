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
        if (other.gameObject.CompareTag("Lemon"))
        {
            gameAudio.PlayOneShot(fruitSound, 1.0f);
            Destroy(other.gameObject);
            spawnManager.UpdateScore(5);
        }
        else if (other.gameObject.CompareTag("Peach"))
        {
            gameAudio.PlayOneShot(fruitSound, 1.0f);
            Destroy(other.gameObject);
            spawnManager.UpdateScore(5);
        }
        else if (other.gameObject.CompareTag("Watermelon"))
        {
            gameAudio.PlayOneShot(fruitSound, 1.0f);
            Destroy(other.gameObject);
            spawnManager.UpdateScore(15);
        }
        else if (other.gameObject.CompareTag("Peanut"))
        {
            gameAudio.PlayOneShot(fruitSound, 1.0f);
            Destroy(other.gameObject);
            spawnManager.UpdateScore(10);
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
            GameObject[] lemonDestroyer = GameObject.FindGameObjectsWithTag("Lemon");
            foreach (GameObject lemon in lemonDestroyer)
            {
                Destroy(lemon);
            }
            GameObject[] peachDestroyer = GameObject.FindGameObjectsWithTag("Peach");
            foreach (GameObject peach in peachDestroyer)
            {
                Destroy(peach);
            }
            GameObject[] watermelonDestroyer = GameObject.FindGameObjectsWithTag("Watermelon");
            foreach (GameObject watermelon in watermelonDestroyer)
            {
                Destroy(watermelon);
            }
            GameObject[] peanutDestroyer = GameObject.FindGameObjectsWithTag("Peanut");
            foreach (GameObject peanut in peanutDestroyer)
            {
                Destroy(peanut);
            }
        }
    }
}
