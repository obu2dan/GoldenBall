using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D player_rb;
    [SerializeField]
    private int player_speed;
    [SerializeField]
    private float player_low;
    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    private void Move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            player_rb.velocity = new Vector2(0,player_speed);
            if(Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)){
            player_rb.velocity = new Vector2(0,player_speed / player_low);
            }
        }
            if(Input.GetKeyUp(KeyCode.UpArrow))
            {
                player_rb.velocity = new Vector2(0,0);
            }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            player_rb.velocity = new Vector2(0,-player_speed);
            if(Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.LeftShift)){
            player_rb.velocity = new Vector2(0,-player_speed / player_low);
            }
        }
            if(Input.GetKeyUp(KeyCode.DownArrow))
            {
                player_rb.velocity = new Vector2(0,0);
            }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            player_rb.velocity = new Vector2(-player_speed,0);
            if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.LeftShift))
            {
            player_rb.velocity = new Vector2(-player_speed / player_low,0);
            }
        }
            if(Input.GetKeyUp(KeyCode.LeftArrow))
            {
                player_rb.velocity = new Vector2(0,0);
            }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            player_rb.velocity = new Vector2(player_speed,0);
            if(Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.LeftShift))
            {
            player_rb.velocity = new Vector2(player_speed / player_low,0);
            }
        }
            if(Input.GetKeyUp(KeyCode.RightArrow))
            {
            player_rb.velocity = new Vector2(0,0);
            }
    }

}
