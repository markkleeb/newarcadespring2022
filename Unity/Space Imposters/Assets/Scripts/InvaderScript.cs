using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvaderScript : MonoBehaviour
{
    //invader speed variable
    public static float speed = 2;
    private GameController gcscript;
    

    // Start is called before the first frame update
    void Start()
    {
        gcscript = GameObject.FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        //Move to the right every frame
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }

    //collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {

        //check to see if we collide with the wall
        if (collision.gameObject.tag == "LeftWall")
        {
            speed = 2;

            GameObject[] invaders = GameObject.FindGameObjectsWithTag("Invader");

            foreach (GameObject i in invaders)
            {
                i.transform.Translate(Vector2.down * 20 * Time.deltaTime);
            }
        }

        if (collision.gameObject.tag == "RightWall")
        {
            speed = -2;

            GameObject[] invaders = GameObject.FindGameObjectsWithTag("Invader");

            foreach (GameObject i in invaders)
            {
                i.transform.Translate(Vector2.down * 20 * Time.deltaTime);
            }
        }

        if (collision.gameObject.tag == "Player")
        {

            Destroy(collision.gameObject);
            gcscript.killed();

        }


    }
}
