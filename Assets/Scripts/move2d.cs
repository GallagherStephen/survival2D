using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move2d : MonoBehaviour
{
    public Transform player;
    public float moveSpeed = 5f; //SETTING THE MOVE SPEED
    public GameObject bulletPrefab;

    //=====================================================================
    //START
    // Start is called before the first frame update
    //=====================================================================
    void Start()
    {
        
    }

    //=====================================================================
    //UPDATE
    // Update is called once per frame
    //=====================================================================
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        if (Input.GetMouseButton(0)) 
        {
            shootBullet(); //shoot
        }
    }

    //=======================================================================
    //JUMP METHOD
    //========================================================================
    void Jump()
    {
        if (Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse);
        }
    }

    //==================================
    //SHOOT BULLET
    //==================================
    public void shootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position; //keeps the bullt location stuck to the player position
    }

}
