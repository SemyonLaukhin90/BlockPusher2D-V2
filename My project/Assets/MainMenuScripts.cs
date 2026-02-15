using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScripts : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        
    }
    public void PressPlay()
    {
        SceneManager.LoadScene("LevelsMenu");
    }
    public void PressSettings()
    {
        //SceneManager.LoadScene("LevelsMenu");
    }
    public void PressExit()
    {
        Application.Quit();
    }
}
