using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //public GameObject  PlayerHealth;

    
    private GameObject vinemonster;
    private int HP = 100;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sword")
        {
            HP -= 25;
            //Debug.Log(20);
        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);

        }
    }
}


    


