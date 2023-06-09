using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundRoing : MonoBehaviour
{
    [Range(1f, -1f)]
    public float ScrollSpeed = 0.5f;

    private float offset;
    private Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * ScrollSpeed) / 10f;
        mat.SetTextureOffset("_MainTex", new Vector2(offset,0 ));
    }
}
