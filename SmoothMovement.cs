using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public float playerSpeed = 5;
    private Rigidbody2D rb;
    // Select Interpolate from Interpolate

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float HorizontalMove = Input.GetAxis("Horizontal");
        float VerticalMove = Input.GetAxis("Vertical");
        Vector3 moveInput = new Vector3(HorizontalMove, VerticalMove, 0);

        Vector3 nextPosition = transform.position + moveInput * playerSpeed * Time.deltaTime;
        rb.MovePosition(nextPosition);
    }
}
