using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool onGround;
    public float high;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        onGround = true;
        rb = GetComponent<Rigidbody>();;
    }

    // Update is called once per frame
    void Update()
    {
        if(onGround) {
            if(Input.GetButtonDown("Jump")) {
                //rb.velocity = new Vector3(0f, high, 0f); --- jump without left/right movement 
                rb.AddForce(new Vector3(0f, high, 0f), ForceMode.Impulse);
                onGround = false;
            }
        }
    }

    void OnCollisionEnter(Collision any) {
        any.gameObject.CompareTag("Ground");
        onGround = true;
    } 

    
}
