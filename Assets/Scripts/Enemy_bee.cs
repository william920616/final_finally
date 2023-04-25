using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_bee : MonoBehaviour
{
    public Transform firePoint;
   
    public GameObject bullet;

    private float HP = 100;
    void Start()
    {
        StartCoroutine(KeepShooting());

    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator KeepShooting()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
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
        if (other.gameObject.tag == "Player")
        {
            PlayerController.HP -= 10;
            //Debug.Log(10);
        }
    }
}
