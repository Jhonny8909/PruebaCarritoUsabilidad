using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    [Range(1f, 20f)]
    public float scrollSpeed = 5;
    public float ScrollOfSet;
    private Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material;    
    }

    // Update is called once per frame
    void Update()
    {
        ScrollOfSet += (Time.deltaTime * scrollSpeed) / 10;
        mat.SetTextureOffset("_MainTex",new Vector2(0,ScrollOfSet));
    }
}
