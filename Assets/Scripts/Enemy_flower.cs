using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_flower : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    public Transform firePoint4;
    public Transform firePoint5;
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
            yield return new WaitForSeconds(4f);
            Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
            Instantiate(bullet, firePoint2.transform.position, firePoint2.transform.rotation);
            Instantiate(bullet, firePoint3.transform.position, firePoint3.transform.rotation);
            Instantiate(bullet, firePoint4.transform.position, firePoint4.transform.rotation);
            Instantiate(bullet, firePoint5.transform.position, firePoint5.transform.rotation);
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