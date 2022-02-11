using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KirbyScript : MonoBehaviour
{

    public KeyCode moveLeft;
    public KeyCode moveRight;
    public KeyCode jump;
    public float speed = 10f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetKey(moveLeft))
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            Debug.Log("pressing left");

            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        //if (Input.GetKey(moveRight))
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(jump))
        {
            transform.Translate(Vector3.up * 100 * Time.deltaTime);
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
