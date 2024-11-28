using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OauseManager : MonoBehaviour
{
    public GameObject PauseMenuPanel;
    public Button ContinueButton;
    public Button MenuButton;
    private bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenuPanel.SetActive(false);

        ContinueButton.onClick.AddListener(ContinueGame);
        MenuButton.onClick.AddListener(GoToMainMenu);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ContinueGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        PauseMenuPanel.SetActive(true);
    }

    void ContinueGame()
    {
        isPaused = false;
        Time.timeScale = 1f;
        PauseMenuPanel.SetActive(false);
    }

    void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

}
