using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public bool go = true;
    public float speed = 1;

    private float HP = 100;

    void Start()
    {
        StartCoroutine(Move1_IE());
        go = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (go == true)
            transform.Translate(-3 * Time.deltaTime, 0, 0);
    }
    IEnumerator Move1_IE()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            yield return new WaitForSeconds(0.5f);
            go = false;
            yield return new WaitForSeconds(0.5f);
            go = true;
            yield return new WaitForSeconds(1f);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            yield return new WaitForSeconds(0.5f);
            go = false;
            yield return new WaitForSeconds(0.5f);
            go = true;
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
            PlayerController.HP -= 30;
            //Debug.Log(10);
        }
    }
}