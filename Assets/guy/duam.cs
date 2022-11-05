using UnityEngine;
using UnityEngine.SceneManagement;


public class duam : MonoBehaviour
{
    [SerializeField] public float speedN = 15f;
    [SerializeField] public float jumpForce = 13f;
    //public GameObject GO;
    public float speed;
    public int GoToScene;

    private Rigidbody2D rb;
    private void Awake()
    {
        GoToScene = 2;
        speed = 0;
        rb = GetComponent<Rigidbody2D>();
    }


    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedN * Time.deltaTime);
    
    }
    private void RunB()
    {
        Vector3 dir = transform.right * speed;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedN * Time.deltaTime);
    }
    public void OnButton_leftDown()
    {
        speed = speedN * -1;
        RunB();
    }
    public void OnButton_RightDown()
    {
        speed = speedN;
        RunB();
    }
    public void OnButton_MuveUp()
    {
        speed = 0;
    }
    private void Update()
    {
        if (true)
            RunB();
        if (Input.GetButton("Horizontal"))
            Run();
        if (Input.GetButtonDown("Jump"))
            Jump();
    }
    public void OnButtonGo() 
    {
        Invoke("y", 2);
    }
    private void y()
    {
        SceneManager.LoadScene(GoToScene+2);
    }
    public void OnButton_UpDown()
    {
        Jump();
    }
    private void Jump()
    {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }
    //private void OnTriggerEnter2D(Collider2D collision) 
    //{
    //    if (collision.tag == "1")
    //    {
    //        GoToScene = 2;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "2")
    //    {
    //        GoToScene = 3;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "3")
    //    {
    //        GoToScene = 4;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "4")
    //    {
    //        GoToScene = 5;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "5")
    //    {
    //        GoToScene = 6;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "6")
    //    {
    //        GoToScene = 7;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "7")
    //    {
    //        GoToScene = 8;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "8")
    //    {
    //        GoToScene = 9;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "9")
    //    {
    //        GoToScene = 10;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "10")
    //    {
    //        GoToScene = 11;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "11")
    //    {
    //        GoToScene = 12;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "12")
    //    {
    //        GoToScene = 13;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "13")
    //    {
    //        GoToScene = 14;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "14")
    //    {
    //        GoToScene = 15;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "15")
    //    {
    //        GoToScene = 16;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "16")
    //    {
    //        GoToScene = 17;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "17")
    //    {
    //        GoToScene = 18;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "18")
    //    {
    //        GoToScene = 19;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "19")
    //    {
    //        GoToScene = 20;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "20")
    //    {
    //        GoToScene = 21;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "21")
    //    {
    //        GoToScene = 22;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "22")
    //    {
    //        GoToScene = 23;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "23")
    //    {
    //        GoToScene = 24;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "24")
    //    {
    //        GoToScene = 25;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "25")
    //    {
    //        GoToScene = 26;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "26")
    //    {
    //        GoToScene = 27;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "27")
    //    {
    //        GoToScene = 28;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "28")
    //    {
    //        GoToScene = 29;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "29")
    //    {
    //        GoToScene = 30;
    //        //GO.SetActive(true);
    //    }
    //    if (collision.tag == "30")
    //    {
    //        GoToScene = 31;
    //        //GO.SetActive(true);
    //    }
    //}
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.tag == "1" || collision.tag == "2" || collision.tag == "3" || collision.tag == "4" || collision.tag == "5" || collision.tag == "6" || collision.tag == "7" || collision.tag == "8" || collision.tag == "9" || collision.tag == "10" || collision.tag == "11" || collision.tag == "12" || collision.tag == "13" || collision.tag == "14" || collision.tag == "15" || collision.tag == "16" || collision.tag == "17" || collision.tag == "18" || collision.tag == "19" || collision.tag == "20"|| collision.tag == "21" || collision.tag == "22" || collision.tag == "23" || collision.tag == "24" || collision.tag == "25" || collision.tag == "26" || collision.tag == "27" || collision.tag == "28" || collision.tag == "29" || collision.tag == "30")
    //    {
    //        GoToScene = 1;
    //    }
    //}
}