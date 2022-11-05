using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsSckript : MonoBehaviour
{
    public int GoToWhatLeve;
    public GameObject Pleyr;
    public GameObject GoButom;
    private SpriteRenderer sprite;
    public Sprite no;
    public int l;


    private void Awake()
    {
        l = PlayerPrefs.GetInt("levels", 1);
        if (l < GoToWhatLeve)
        {
            sprite = GetComponentInChildren<SpriteRenderer>();
            sprite.sprite = no;
        }
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (l >= GoToWhatLeve)
            if (collision.tag == "Player")
            {
                duam gamer = Pleyr.GetComponent<duam>();
                gamer.GoToScene = GoToWhatLeve;
                GoButom.SetActive(true);
            }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            duam gamer = Pleyr.GetComponent<duam>();
            gamer.GoToScene = 0;
            GoButom.SetActive(false);
        }
    }
}
