using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class MenuGuyMuver : MonoBehaviour
{
    public int Way;
    public int speedN, res = 100, timer = 0;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    public Sprite[] SpriteMass;

    
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        sprite.sprite = SpriteMass[Random.Range(0, SpriteMass.Length)];
        rb = GetComponent<Rigidbody2D>();
        speedN = Random.Range(4, 15);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Run();
        timer++;
        if(timer > res){
            res = Random.Range(100, 500);
            timer = 0;
            Jump();
        }
    }

    private void Jump()
    {
        rb.AddForce(transform.up * 10, ForceMode2D.Impulse);
    }

    private void Run()
    {
        Vector3 dir = transform.right * Way;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedN * Time.deltaTime);
        //RunSaund.Play();  
    }


}
