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

}