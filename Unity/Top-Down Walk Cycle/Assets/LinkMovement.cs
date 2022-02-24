using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinkMovement : MonoBehaviour
{

    Vector3 movement;
    public float speed = 10f;

    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        transform.Translate(movement * speed * Time.deltaTime);
        
    }
}
