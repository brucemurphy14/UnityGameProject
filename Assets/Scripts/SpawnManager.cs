using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitPrefabs;
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    //public GameObject gameScore;
    public Button mainMenuButton;
    public bool isGameActive = true;
    public TextMeshProUGUI scoreText;
    private int score;
    private float SpawnRangeX = 15;
    private float SpawnPosZ = 10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    private AudioSource gameAudio;
    public AudioClip rockSound;

    // Start is called before the first frame update
    void Start()
    {

        //gameOverText.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {    
    }
    void SpawnRandomFruit()
    {
        if (isGameActive)
        {
            int fruitIndex = Random.Range(0, fruitPrefabs.Length);
            Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 1, SpawnPosZ);
            Instantiate(fruitPrefabs[fruitIndex], SpawnPos, fruitPrefabs[fruitIndex].transform.rotation);
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    public void StartGame()
    {
        
        InvokeRepeating("SpawnRandomFruit", startDelay, spawnInterval);
        isGameActive = true;
        
        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        mainMenuButton.gameObject.SetActive(true);
        //mainMenuButton.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void MainMenu()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        /*
        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        mainMenuButton.gameObject.SetActive(false);

        StartGame();
        */
    }
}
