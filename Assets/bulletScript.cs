using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    public float speed = 50.0f;    //speed of the bullet
    private Rigidbody2D rb;        //Reference for the rigid body
    private Vector2 screenBounds;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > screenBounds.x * -2) //multiply by a negative to get the right side of the screen .destroys it when off screen
        {
            Destroy(this.gameObject); //destroys the bullet
        }
    }
}
