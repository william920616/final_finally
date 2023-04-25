using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Attack : MonoBehaviour
     {

    public int damage=2;
    public int HP = 10;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
            if (collision.gameObject.tag == "Enemy")
            {
            HP = HP - damage;
            }
        }
    }

