using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScenes2 : MonoBehaviour
{
    public bool p1in;
    public bool p2in;
    public bool can_Load;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (p1in == false & p2in == false)
            can_Load = false;
        if (p1in == true & p2in == true)
            can_Load = false;
        if (p1in == true & p2in == false)
            can_Load = true;
        if (p1in == false & p2in == true)
            can_Load = true;
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

}
