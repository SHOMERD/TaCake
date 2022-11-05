using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DUAM2 : MonoBehaviour
{
    public int levelUnLock;
    public GameObject EndeBatun;

    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" || collision.tag == "Player2")
        {
            Invoke("NextLevel", 1);
        }

    }
    public void NextLevel()
    {
        EndeBatun.SetActive(true);

    }
    public void Ret()
    {
        //PlayerPrefs.SetInt("levels", 1);
        SceneManager.LoadScene(0);
    }


}