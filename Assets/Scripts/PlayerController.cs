using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float playerSpeed = 30.0f;

    [SerializeField]
    private Rigidbody playerRB;  // geting rigidbody component for movement.


    // Add Rigidbody to the Player.

    private void FixedUpdate()
    {

        if (Input.GetKey("a"))
        {
            playerRB.AddForce(-10, 0, 0 * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            playerRB.AddForce(10, 0, 0 * Time.deltaTime);
        }
        else if (Input.GetKey("w"))
        {
            playerRB.AddForce(0, 0, 1000 * Time.deltaTime);
        }
        else if (Input.GetKey("s"))
        {
            playerRB.AddForce(0, 0, -1000 * Time.deltaTime);
        }
    }
}