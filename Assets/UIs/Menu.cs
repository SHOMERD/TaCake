using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public GameObject GO;
    public GameObject Ghits;
    //public GameObject text;
    private void Awake()
    {
        GO.SetActive(false);
        //text = GetComponent<Text>;



    }

    public void OnMenuButtonDown()
    {
        Time.timeScale = 0f;
        GO.SetActive(true);
    }
    public void OnGoButtonDown()
    {
        GO.SetActive(false);
        Time.timeScale = 1f;


    }
    public void OnMainMenuButtonDown()
    {
        SceneManager.LoadScene(0);

    }
    public void OnResetButtonDown()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ChitManu()
    {
        if (Ghits.active == true)
        {
            Ghits.SetActive(false);
            GO.SetActive(true);
        }
        if (Ghits.active == false)
        {
            Ghits.SetActive(true);
            GO.SetActive(false);
        }
    }

    public void next() {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);}
    public void back() { SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1); }


}
