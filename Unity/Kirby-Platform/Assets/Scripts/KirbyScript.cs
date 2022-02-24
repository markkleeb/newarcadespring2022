using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbyScript : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode jump;
    public float speed = 10f;

    private bool facingRight = true;

    public Sprite idleSlime;
    public Sprite jumpSlime;

    private Rigidbody2D rb;
    private SpriteRenderer slimeSR;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        slimeSR = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(moveLeft))
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("pressing left");
            facingRight = false;
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        //if (Input.GetKey(moveRight))
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            facingRight = true;
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetAxisRaw("Jump") > 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            slimeSR.sprite = jumpSlime;
        }
        else
        {
            slimeSR.sprite = idleSlime;
        }

        if (facingRight)
        {
            slimeSR.flipX = false;
        }
        else
        {
            slimeSR.flipX = true;
        }


    }

    private void FixedUpdate()
    {

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
           // rb.AddForce(Vector3.left * speed);
        }

        
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //rb.AddForce(Vector3.right * speed);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }
}
