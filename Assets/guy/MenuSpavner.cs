using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpavner : MonoBehaviour
{
    public GameObject Guy;
    public int timer = 0, res = 100;
    public int ThisWay;


    // Update is called once per frame
    void Update()
    {
        timer++;
        if(timer > res){
            res = Random.Range(100, 700);
            timer = 0;
            Spavn();
        }
    }

    public void Spavn(){
        GameObject c = Instantiate(Guy, transform.position, transform.rotation);
        c.GetComponent<MenuGuyMuver>().Way = ThisWay;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "MenuGuy"){
            Destroy(other.gameObject);
        }
    }
}
