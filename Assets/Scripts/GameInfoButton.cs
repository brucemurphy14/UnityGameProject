using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameInfoButton : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject gameInfoScreen;
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(GameInfo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GameInfo()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameInfoScreen.gameObject.SetActive(true);
        titleScreen.gameObject.SetActive(false);
    }
}
