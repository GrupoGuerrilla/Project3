using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    public float speed;
    private Rigidbody2D body;
    Vector2 direction;


	// Use this for initialization
	void Start () 
    {
        body = GetComponent<Rigidbody2D>();
        speed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () 
    {
        GetInput();
        Move();
	}

    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void GetInput()
    {
        direction = Vector2.zero;

        if(Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
        }

        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
        }

        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
        }

        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
        }
    }
}
