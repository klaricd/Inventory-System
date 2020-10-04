using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float MoveSpeed = 5f;

    public Rigidbody2D Rigidbody;
    public Animator Animator;

    Vector2 Movement;

    void Update()
    {
        // Input
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");

        Animator.SetFloat("Horizontal", Movement.x);
        Animator.SetFloat("Vertical", Movement.y);
        Animator.SetFloat("Speed", Movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        // Movement
        Rigidbody.MovePosition(Rigidbody.position + Movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
