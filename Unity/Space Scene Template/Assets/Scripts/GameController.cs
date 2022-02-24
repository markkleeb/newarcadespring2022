using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //Grab the ship object
    public GameObject ship;

    //Grab the invader object
    public GameObject invader;

    //Grab the "life" object
    public GameObject life;

    private int lives = 3;

 
    // Start is called before the first frame update
    void Start()
    {

        Instantiate(ship, new Vector3(0, -3), Quaternion.identity);

        //draw 10 invaders across
        for (int i = -5; i < 5; i++)
        {
            //draw 3 rows down
            for (int j = 2; j < 5; j++)
            {
                Instantiate(invader, new Vector3(i, j), Quaternion.identity);
            }
        }

        //draw 3 lives across the top
        for (int i = 0; i < lives; i++)
        {
            Instantiate(life, new Vector3(i + 6, 4), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
       


    }

  
}
