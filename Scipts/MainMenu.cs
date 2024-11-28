using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Button level1button;
    public Button level2button;
    // Start is called before the first frame update
    void Start()
    {
        level1button.onClick.AddListener(LoadLevel1);
        level2button.onClick.AddListener(LoadLevel2);
        
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("1Level");
    }

    void LoadLevel2()
    {
        SceneManager.LoadScene("2Level");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
