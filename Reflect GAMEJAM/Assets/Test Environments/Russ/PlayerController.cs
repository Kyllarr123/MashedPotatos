using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    Vector3 jump;
    public float jumpForce;
    public GameObject rayOrigin;
    public float rayCheckDistance;
    private Rigidbody rb;
    public bool isGrounded;
 
    void Start () {
        rb = GetComponent <Rigidbody> ();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }
    
    void OnCollisionStay()
    {
        isGrounded = true;
    }
 
    void Update () {
        float x = Input.GetAxis ("Horizontal");
        if (Input.GetButtonDown("Jump")) 
        {
            Debug.Log("presseed");
            if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
            {     
                rb.AddForce(jump * jumpForce, ForceMode.Impulse);
                isGrounded = false;
            }
            
        }
        rb.velocity = new Vector3 (x * speed, rb.velocity.y, 0);
 
    }
}
