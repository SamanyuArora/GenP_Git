using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementplayer : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 500f;
    public float sidewaysForce = 600f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         rb.AddForce(0, 0, forwardForce*Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a")){
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
