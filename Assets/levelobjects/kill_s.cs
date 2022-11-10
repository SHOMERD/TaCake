using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using System.Timers;


public class kill_s : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" || collision.tag == "Player2")
        {
            Destroy(collision.gameObject);
            Invoke("reloud", 2);

        }

    }

    private void reloud() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}

