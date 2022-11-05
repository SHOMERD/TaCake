using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class NextScenes : MonoBehaviour
{
    public bool oneGuy = false;
    public bool can_LoadScene = false;
    public bool can_LoadScene1 = false;
    public int NawLevelIs;
    private SpriteRenderer sprite;
    private SpriteRenderer s_sprite;
    public Sprite cake1;
    public Sprite cake2;

    public GameObject next2;
    public bool p1in;
    public bool p2in;




    private void Awake()
    {
        NawLevelIs = SceneManager.GetActiveScene().buildIndex;
        if (oneGuy == false)
        {
            s_sprite = next2.GetComponentInChildren<SpriteRenderer>();
            s_sprite.sprite = cake1;
        }
        sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.sprite = cake1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player")
        {
            p1in = true;
        }

        if (collision.tag == "Player2")
        {
            p2in = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player2")
        {
            p2in = false;
        }
        if (collision.tag == "Player")
        {
            p1in = false;
        }
    }
    private void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Time.timeScale = 1f;
    }

    private void Update()
    {
        if (p1in == true & p2in == true)
            can_LoadScene1 = false;
        if (p1in == false & p2in == false)
            can_LoadScene1 = false;
        if (p1in == true & p2in == false)
            can_LoadScene1 = true;
        if (p1in == false & p2in == true)
            can_LoadScene1 = true;
        NextScenes2 cl = next2.GetComponent<NextScenes2>();
        can_LoadScene = cl.can_Load;
        if (can_LoadScene1 == true & (can_LoadScene == true || oneGuy == true))
        {
            if (oneGuy == false)
                s_sprite.sprite = cake2;
            sprite.sprite = cake2;
            UnLockLevel();
            Invoke("NextLevel", 1);
        }
    }

    public void UnLockLevel()
    {
        if (NawLevelIs >= PlayerPrefs.GetInt("levels"))
        {
            PlayerPrefs.SetInt("levels", NawLevelIs);
        }
    }
}
