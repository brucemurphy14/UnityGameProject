using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuButton : MonoBehaviour
{
    private Button button;
    public GameObject titleScreen;
    public GameObject gameInfoScreen;
    private SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(MainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MainMenu()
    {
        Debug.Log(button.gameObject.name + " was clicked");
        gameInfoScreen.gameObject.SetActive(false);
        titleScreen.gameObject.SetActive(true);
    }
}
