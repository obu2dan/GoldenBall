using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    private Rigidbody2D background_rb;
    [SerializeField]
    private float BackGround_speed;
    // Start is called before the first frame update
    void Start()
    {
        background_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        background_rb.velocity = new Vector2(0,-BackGround_speed);
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Scroller"){
            this.transform.position = new Vector2(-2.33f,10f);
        }
    }
}

