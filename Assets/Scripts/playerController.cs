using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] float idleSwitchTime;
    float nextIdleSwitch;

    float move;
    float run;
    bool isRunning;

    //for jumping
    bool grounded;
    Collider[] groundCollider;
    [SerializeField] Transform groundCheck;
    float checkRadius = .05f;
    [SerializeField] LayerMask groundMask;
    [SerializeField] float jumpForce;

    [SerializeField] Rigidbody playerRB;
    [SerializeField] Animator playerAnim;

    private void Start()
    {
        nextIdleSwitch = Time.time + idleSwitchTime;
        isRunning = false;
    }

    private void Update()
    {
        if (grounded && Input.GetAxis("Jump") > 0)
        {
            playerAnim.SetBool("isGrounded", false);
            playerRB.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
            grounded = false;
        }

        groundCollider = Physics.OverlapSphere(groundCheck.position, checkRadius, groundMask);
        grounded = (groundCollider.Length > 0);

        playerAnim.SetBool("isGrounded", grounded);
        playerAnim.SetFloat("verticalForce", playerRB.velocity.y);

        if (Time.time > nextIdleSwitch)
        {
            //50% chance to switch
            int i = Random.Range(0, 10);
            if (i > 4)
            {
                playerAnim.SetTrigger("IdleTrigger");
            }
            nextIdleSwitch = Time.time + idleSwitchTime;
        }

        move = Mathf.Abs(Input.GetAxis("Vertical"));

        run = Input.GetAxisRaw("Fire3");
        isRunning = (run > 0);

        playerAnim.SetBool("running", isRunning);
        playerAnim.SetFloat("walkFloat", move);
    }
}
