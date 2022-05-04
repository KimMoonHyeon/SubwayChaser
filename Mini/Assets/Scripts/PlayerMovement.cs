using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpPower = 300f;

    private Rigidbody playerRigidbody;
    private Animator playerAnimator;

    private void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        playerAnimator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Move();     // �׻� ������ �̵�

        if (Input.GetKeyDown(KeyCode.Z))    // ���� ȸ��
        {
            RotateLeft();
        }
        if (Input.GetKeyDown(KeyCode.C))    // ������ ȸ��
        {
            RotateRight();
        }
        if (Input.GetMouseButtonDown(1))    // ���� (���콺 ��Ŭ��)
        {
            Jump();
        }
        if (Input.GetMouseButtonDown(0))    // Į �ֵѷ��� ��Ʈ ���� (���콺 ��Ŭ��)
        {
            Brandish();
        }
    }

    private void Move()
    {
        Vector3 moveDistance = transform.forward * moveSpeed * Time.deltaTime;

        playerRigidbody.MovePosition(playerRigidbody.position + moveDistance);
        //playerAnimator.SetBool("isRunning", moveDistance != Vector3.zero);
    }

    private void RotateLeft()
    {
        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, -90, 0f);
    }

    private void RotateRight()
    {
        playerRigidbody.rotation = playerRigidbody.rotation * Quaternion.Euler(0, 90, 0f);
    }
    private void Jump()
    {
        // ���� ���� �ȵǰ� �ϱ�
        Debug.Log("jump");
        playerRigidbody.AddForce(new Vector3(0, 1f, 0) * jumpPower);
    }
    private void Brandish()
    {

    }
}