using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_tree : MonoBehaviour
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
        yield return new WaitForSeconds(0.5f);
        Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        yield return new WaitForSeconds(0.5f);
        Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        StartCoroutine(Shooting());
    }

    IEnumerator Shooting()
    {
        yield return new WaitForSeconds(1f);
        StartCoroutine(KeepShooting());
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
