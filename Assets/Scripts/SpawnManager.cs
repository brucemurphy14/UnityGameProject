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
    public Button restartButton;
    public bool isGameActive;
    private float SpawnRangeX = 23;
    private float SpawnPosZ = 10;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

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

    public void StartGame()
    {
        InvokeRepeating("SpawnRandomFruit", startDelay, spawnInterval);
        isGameActive = true;

        titleScreen.gameObject.SetActive(false);
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
