
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 3.0f;
    
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // You can use what ever Following Input type to call/move Charecter

        /*  transform.Translate(Vector3.right * horizontalInput * _playerSpeed * Time.deltaTime);
          transform.Translate(Vector3.forward * verticalInput * _playerSpeed * Time.deltaTime);

                                                OR                                               

         transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * _playerSpeed * Time.deltaTime ); 

        */

        Vector3 movement = new Vector3 (horizontalInput, 0, verticalInput);
        transform.Translate( movement * _playerSpeed * Time.deltaTime );

    }
}
