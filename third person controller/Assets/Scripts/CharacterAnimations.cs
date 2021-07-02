using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimations : MonoBehaviour
{

    public Animator animator;
    public float acceleration = 0.1f;
    public float deceleration = 0.5f;
    float velocity = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //bool isWalking = animator.GetBool("isWalking");
        //bool isRunning = animator.GetBool("isRunning");
        bool runPressed = Input.GetKey("left shift");

        bool movementPressed = Input.GetKey("w") || Input.GetKey("s") || Input.GetKey("a") || Input.GetKey("d");


        if (movementPressed && velocity < 1.0f)
        {
            velocity += Time.deltaTime * acceleration;
        }

        if (!movementPressed && velocity > 0.0f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if (!movementPressed && velocity < 0.0f)
        {
            velocity = 0.0f;
        }

        animator.SetFloat("Velocity", velocity);

        /*
        if (!isWalking && movementPressed)
        {
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !movementPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isRunning && (movementPressed && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        if (isRunning && (!movementPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
        */
    }
}
