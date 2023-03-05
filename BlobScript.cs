using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BlobScript : MonoBehaviour
{
    // References
    public Rigidbody2D myRigidBody;
    public float jumpStrength = 8;
    public SpriteRenderer mySpriteRenderer;
    public Sprite spriteBlobUp;
    public Sprite spriteBlobDown;
    public LogicScript logic;
    public bool blobNotDead = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && blobNotDead )
        {
            myRigidBody.velocity = Vector2.up * jumpStrength;
        }

        if (myRigidBody.velocity.y > 0)
        {
            mySpriteRenderer.sprite = spriteBlobUp;
        }
        else
        {
            mySpriteRenderer.sprite = spriteBlobDown;
        }
    }
    public void OnCollisionEnter2D(Collision2D col)
    {

        logic.gameOver();
        blobNotDead = false;
        Debug.Log("Dead.");
    }

    


    // Update is called once per frame
}
