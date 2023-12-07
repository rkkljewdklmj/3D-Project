using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float VerticalInput;

    Vector3 MoveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb= GetComponent<Rigidbody>();
        rb.freezeRotation= true;
    }

    private void Update()
    {
        MyInput();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        MoveDirection = orientation.forward * VerticalInput +orientation.right * horizontalInput;
        Debug.Log("Move direction = " + MoveDirection);
        rb.AddForce(MoveDirection.normalized * moveSpeed * 10f, ForceMode.Force);
    }

}
