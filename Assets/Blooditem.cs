using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blooditem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")

        {
            PlayerController.HP += 25;
            if (PlayerController. HP >100)
            {
                PlayerController.HP = 100;
            }
            Destroy(gameObject);
        }
    }
}
