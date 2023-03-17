using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_move : MonoBehaviour
{
    private float BulletSpeed = 2;
    private float Timer = 0;
    public GameObject Bullet;
    void Start()
    {
        Timer = 0;
        GameObject.Destroy(Bullet, 6.0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * BulletSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Monster_Bullet")
        {
            return;
        }
        else
        {
            if (collision.tag == "Wall")
            {
                Destroy(this.gameObject);
            }
            if (collision.tag == "Player")
            {
                Destroy(this.gameObject);
            }
        }

    }
}
