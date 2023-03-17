using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float runSpeed = 5;
    public float jumpSpeed = 6;
    public Animator myAnim;

    private Rigidbody2D myrigidbody;
    private BoxCollider2D myFeet;
    private bool isGround;
    private bool F4147F;
         
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        myAnim = GetComponent<Animator>();
        myFeet = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            StartCoroutine(Move1_IE());
        }

        Run();
        Jump();
        CheckGrounded();
      
    }
    void CheckGrounded()
    {
        isGround = myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"));
        Debug.Log(isGround);
    }
    void Run()
    {
        
        float moveDir = Input.GetAxis("Horizontal");
        Vector2 playerVel = new Vector2(moveDir * runSpeed, myrigidbody.velocity.y);
        myrigidbody.velocity = playerVel;

            if (Input.GetKey(KeyCode.RightArrow))
        {
            // transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            myAnim.SetBool("7414", true);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // transform.Translate(speed * Time.deltaTime, 0, 0);
            transform.rotation = Quaternion.Euler(0, 180, 0);
            myAnim.SetBool("7414", true);
        }
        bool plyerHasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
        myAnim.SetBool("Run", plyerHasXAxisSpeed);
        if (plyerHasXAxisSpeed == false)
            myAnim.SetBool("7414", false);
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (isGround)
            {
                Vector2 jumpVel = new Vector2(0.0f, jumpSpeed);
                myrigidbody.velocity = Vector2.up * jumpVel;

            }


        }
    }
    IEnumerator Move1_IE()
    {
        F4147F = true;
        myAnim.SetBool("4147", true);
        yield return new WaitForSeconds(0.5f);
        myAnim.SetBool("4147", false);
        F4147F = false;
    }
}
