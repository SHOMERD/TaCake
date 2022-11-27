using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class guy_muve : MonoBehaviour
{
    [SerializeField] public float speedN = 11f;
    [SerializeField] public float jumpForce = 13f;
    public float speed;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    public bool IsGrounded;
    public bool IsGrounded1;
    public Transform GroundCheck1;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask TheGround;
    //public AudioSource RunSaund;
    //public AudioSource JampSaund;


    private void Awake()
    {
        speed = 0;
        sprite = GetComponentInChildren<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        //RunSaund = GetComponentInChildren<AudioSource>();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedN * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
        //RunSaund.Play();
    }
    private void RunB()
    {
        Vector3 dir = transform.right * speed;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speedN  * Time.deltaTime);
        sprite.flipX = dir.x < 0.0f;
        //RunSaund.Play();
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
    public void OnButton_UpDown()
    {
        Jump();
    }


    private void FixedUpdate()
    {
        
        if (true)
            RunB();
        if (Input.GetButton("Horizontal"))
            Run();
    }
    private void Update()
    {
        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, TheGround);
        IsGrounded1 = Physics2D.OverlapCircle(GroundCheck1.position, CheckRadius, TheGround);
        if (Input.GetButtonDown("Jump"))
            Jump();
    }



    private void Jump()
    {
        if (IsGrounded ==true|| IsGrounded1 == true)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            //JampSaund.Play();
        }
    }

}