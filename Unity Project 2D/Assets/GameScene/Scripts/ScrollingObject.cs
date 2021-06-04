using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{

    private Rigidbody2D rb2D;
    

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = new Vector2(-1.5f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
