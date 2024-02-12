using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D playerRB;
    private Vector3 moveInput;
    public int moveSpeed = 2;

    void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
    }
    void FixedUpdate()
    {
        Move();
    }
    void Move()
    {
        playerRB.MovePosition(transform.position + moveInput.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
