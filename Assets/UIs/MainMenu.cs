using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    int levelUnLock;
    public GameObject text;
    private void Awake()
    {
        Time.timeScale = 1f;
    }
    public void OnPlayButtonDown()
    {
        levelUnLock = PlayerPrefs.GetInt("levels", 1);
        SceneManager.LoadScene(levelUnLock+1);
    }
    public void OnChuseButtonDown()
    {
        SceneManager.LoadScene(1);
    }
    public void OnQuitButtonDown()
    {
        Application.Quit();
    }
    public void OnResetButtonDown()
    {
        text.SetActive(true);
        PlayerPrefs.SetInt("levels", 1);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Invoke("dam", 2); 
    }
    private void dam() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );  }
}
