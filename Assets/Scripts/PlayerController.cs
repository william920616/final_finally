using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float runSpeed = 5;
    public float jumpSpeed = 100;
    public Animator Anim;
    public float doublejumpspeed;
    public static float HP = 100;
    public GameObject box2;
    public int damage;
    public float time;
    public float StartTime;
    


    private float passedTime = 0; // 用來累加時間的變數
    private float timerInterval = 3; // 設定觸發間隔
    private float n = 0;
    private Rigidbody2D myrigidbody;
    private BoxCollider2D myFeet;
    private bool isGround;
    private bool F4147F;
    private bool canDoubleJump;
    private bool canAttack;



    void Start()
    {
        //GameObject.Find("Player");

        myrigidbody = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
        myFeet = GetComponent<BoxCollider2D>();
        box2.SetActive(false);
        canAttack = true;
    }



    void Update()
    {
        Run();
        Jump();
        CheckGrounded();
        Attack();
    }
    void Attack()
    {
        if (Input.GetButtonDown("Attack") && canAttack == true)
        {
            Anim.SetTrigger("Attack");
            StartCoroutine(StartAttack());
        }

    }


    IEnumerator StartAttack()
    {
        canAttack= false;   
        yield return new WaitForSeconds(StartTime);
        box2.SetActive(true);
        StartCoroutine(disableHitBox());
    }

    IEnumerator disableHitBox()
    {
        yield return new WaitForSeconds(time);
        box2.SetActive(false);
        canAttack = true;
    }

    //if (Input.GetButtonDown("Attack"))
    //{
    //    box2.SetActive(true);
    //    Debug.Log("IN");
    //    Anim.SetTrigger("Attack");





    //    if (Time.deltaTime >= 0.005)
    //    {
    //        box2.SetActive(false);
    //        Debug.Log("IN2");
    //    }
    //    Anim.SetBool("Idle", false);
    //    box2.SetActive(false);

    //}

        void CheckGrounded()
        {
            isGround = myFeet.IsTouchingLayers(LayerMask.GetMask("Ground"));
            //Debug.Log(isGround);
        }
        void Run()
        {
            float moveDir = Input.GetAxis("Horizontal");
            Vector2 playerVel = new Vector2(moveDir * runSpeed, myrigidbody.velocity.y);
            myrigidbody.velocity = playerVel;

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                // transform.Translate(speed * Time.deltaTime, 0, 0);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                // transform.Translate(speed * Time.deltaTime, 0, 0);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
            bool plyerHasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) > Mathf.Epsilon;
            Anim.SetBool("Run", plyerHasXAxisSpeed);
            bool plyer1HasXAxisSpeed = Mathf.Abs(myrigidbody.velocity.x) <= Mathf.Epsilon;
            Anim.SetBool("Idle", plyer1HasXAxisSpeed);

        }


        void Jump()
        {
            if (Input.GetButtonDown("Jump"))
            {
                if (isGround)
                {
                    Vector2 jumpVel = new Vector2(0.0f, jumpSpeed);
                    myrigidbody.velocity = Vector2.up * jumpVel;
                    canDoubleJump = true;
                }
                else
                {
                    if (canDoubleJump)
                    {
                        Vector2 doubleJumpVel = new Vector2(0.0f, doublejumpspeed);
                        myrigidbody.velocity = Vector2.up * doubleJumpVel;
                        canDoubleJump = false;
                    }
                }
                bool plyerHasYAxisSpeed = Mathf.Abs(myrigidbody.velocity.y) > Mathf.Epsilon;
                Anim.SetBool("Jump", plyerHasYAxisSpeed);
            }
        }


        //static public void TakeDamage(int amount)
        //{
        //Debug.Log("t");
        //HP -= amount;

        //Debug.Log(HP);


        

            void OnCollisionEnter2D(Collision2D other)
            {
                if (other.gameObject.tag == "Enemy")
                {
                    HP -= 20;
                    Debug.Log(10);
                }
                if (HP <= 0)
                {
                    Destroy(gameObject);

                }
            }
                }













