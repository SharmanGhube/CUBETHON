using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 500f;

    void FixedUpdate()
    {

        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 


        if (Input.GetKey("d") )
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
           
        }
        

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            
        }

       
        if (Input.GetKey("w"))
        {
            
            rb.AddForce(0, upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }


        if (Input.GetKey("s"))
        {
            
            rb.AddForce(0, -upwardForce * Time.deltaTime, 0,  ForceMode.VelocityChange);
        }

        if (Input.GetKey("q") || Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
           
        }

        if (rb.position.y < -100f)
        {

            FindObjectOfType<GameManager>().EndGame();
        }


    }

}