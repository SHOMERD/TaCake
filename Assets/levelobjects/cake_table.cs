using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cake_table : MonoBehaviour
{
    private SpriteRenderer sprite;
    public Sprite cake1;
    public Sprite cake2;


    private void Awake()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.sprite = cake1;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
