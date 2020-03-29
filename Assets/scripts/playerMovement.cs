using UnityEngine;

public class playerMovement : MonoBehaviour
{   
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sideForce = 300f;

    // Update is called once per frame
        void FixedUpdate()
    {   
        rb.AddForce(0,0, forwardForce * Time.deltaTime, ForceMode.Force);
        if(Input.GetKey("d")){
            rb.AddForce(sideForce *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sideForce *Time.deltaTime, 0, 0,  ForceMode.VelocityChange);
        }
        if(rb.position.y < 4f){
            FindObjectOfType<GameManager>().EndGame();
        }
        if(Input.GetAxis("Jump") != 0){
            rb.AddForce(Vector3.up * 10 * Time.deltaTime *80, ForceMode.Impulse);
        }
    }
    void Update(){ 
        if(Input.touchCount>0){
            Touch touch = Input.GetTouch(0);
            print(touch.position);
            if(touch.position.x>500 ){
                rb.AddForce(200 *Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            if(touch.position.x<500){
                rb.AddForce(-200 *Time.deltaTime, 0, 0,  ForceMode.VelocityChange);
            }
        }
    }
}
