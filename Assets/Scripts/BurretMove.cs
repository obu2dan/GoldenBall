using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurretMove : MonoBehaviour
{
    [SerializeField]
    private int burret_speed = 15;
    private Rigidbody2D burret_rb;
    private Transform burret_tf;
    private float screen_top;
    // Start is called before the first frame update
    private void Start()
    {
        burret_rb = GetComponent<Rigidbody2D>();
        burret_tf = this.transform;
        screen_top = Camera.main.ViewportToWorldPoint(new Vector2(0, 1)).y;
        burret_rb.velocity = burret_tf.up.normalized * burret_speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(burret_rb.simulated == false)
			return;
        if(burret_tf.position.y > screen_top + 1)
        {
           burret_rb.simulated = false;
        }
    }
}
