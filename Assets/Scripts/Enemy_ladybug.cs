using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_ladybug : MonoBehaviour
{
    public bool go = true;
    public float speed = 1;
    private int HP = 50;

    void Start()
    {
        StartCoroutine(Move1_IE());
        go = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (go == true)
            transform.Translate(-2 * Time.deltaTime, 0, 0);
    }
    IEnumerator Move1_IE()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            yield return new WaitForSeconds(3f);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sword")
        {
            HP -= 25;
            Debug.Log(20);
        }
        if (HP <= 0)
        {
            Destroy(this.gameObject);

        }
        if (other.gameObject.tag == "Player")
        {
             PlayerController. HP -= 20;
            //Debug.Log(10);
        }
    }
}




