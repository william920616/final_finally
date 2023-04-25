using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hpbar : MonoBehaviour
{
    private Image bar;
    void Start()
    {
        bar = GetComponent<Image>();
    }
    // Update is called once per frame
    void Update()
    {
        bar.fillAmount =PlayerController.HP/ 100;
    }

    
}
