using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed;
    public float dirX;
    private bool facingRight;
    public Vector3 localScale;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;

        if(CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
        {
            rb.AddForce(Vector2.up * 200f);
        }

        if(Mathf.Abs(dirX) > 0 && rb.velocity.y >= 0)
        {
            anim.SetBool("isRunning", true);
            SoundManager.PlaySound("Run");
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(rb.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", false);
        }

        if(rb.velocity.y > 0)
        {
            anim.SetBool("isJumping", true);
            SoundManager.PlaySound("Jump");
        }

        if(rb.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", true);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate()
    {
        if(dirX > 0)
        {
            facingRight = true;
        }
        else if(dirX < 0)
        {
            facingRight = false;
        }

        if(((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Dead" || col.tag == "Enemy")
        {
            Debug.Log("Mati BOY!!");
            Destroy(GameObject.Find("SoundManager"));
            SceneManager.LoadScene("GameOver");
        }
        if(col.tag == "Finish1"){
            SceneManager.LoadScene("Level 2");
        }
        if(col.tag == "Finish 2"){
            SceneManager.LoadScene("Level 3");
        }
        if(col.tag == "Finish 3"){
            SceneManager.LoadScene("Level 4");
        }
        if(col.tag == "Drop"){
            Destroy(GameObject.Find("tiles_drop"));
        }
        if(col.tag == "Enemy"){
            Destroy(GameObject.Find("tiles_drop"));
            Debug.Log("mati");
        }
        if(col.tag == "Win"){
            SceneManager.LoadScene("WinScene");
        }

    }
}
