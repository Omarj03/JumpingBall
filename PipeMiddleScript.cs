using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;
    public int scoreToAdd = 1;
    public BlobScript blob;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        blob = GameObject.FindGameObjectWithTag("Player").GetComponent<BlobScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == 3 && blob.blobNotDead)
        {
            logic.addScore(scoreToAdd);
        }
    }
}
