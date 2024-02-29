using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;
    private float jumpForce = 10f;
    private float moveSpeed = 10f;
    private float gravity = 2.5f;
    private bool IsJumping;
    private CharacterController characterController;

    void Start()
    {
        IsJumping = false;
        animator = GetComponent<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)) {
            StartJumpingAnimation();
            Jump();
        } 
        if(Input.GetKey(KeyCode.LeftShift)){
            moveSpeed = 16f;
            animator.speed = 1.3f;
        }  
        else{
            moveSpeed = 10f;
            animator.speed = 1f;
        }
    }
    
    private void FixedUpdate() {
        if(IsJumping){
            Jump();
        }
        MovePlayer();
    }

    private void LateUpdate() {
        if(characterController.isGrounded){
            EndJumpingAnimation();
        }
        else{
            ApplyGravity();
        }
    }

    private void MovePlayer(){
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized;

        
        if (movement.magnitude >= 0.1f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movement);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f);

            characterController.Move(movement * moveSpeed * Time.deltaTime);
            if(animator.GetBool("IsJumping") != true){
                animator.SetBool("IsRunning", true);
            }
        }
        else
        {
            if(animator.GetBool("IsRunning") == true){
                animator.SetBool("IsRunning", false);
            }
        }
    }

    private void Jump(){
        characterController.Move(Vector3.up * jumpForce * Time.deltaTime);
    }

    private void ApplyGravity(){
        Vector3 gravityVector = new Vector3(0f, -gravity * Time.deltaTime, 0f);
        characterController.Move(gravityVector);
    }

    private void StartJumpingAnimation(){
        IsJumping = true;
        if(animator.GetBool("IsJumping") != true){
            animator.SetBool("IsJumping", true);
        }
    }

    private void EndJumpingAnimation(){
        IsJumping = false;
        if(animator.GetBool("IsJumping") != false){
            animator.SetBool("IsJumping", false);
        }
    }
}
