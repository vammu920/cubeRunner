using UnityEngine;

public class playerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 300f;

    // Update is called once per frame
    void FixedUpdate()
    {   
        rb.AddForce(0,0, forwardForce * Time.deltaTime);
        if(Input.GetKey("d")){
            rb.AddForce(sideForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce *Time.deltaTime, 0, 0,  ForceMode.VelocityChange);
        }
        if(rb.position.y < 4f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
