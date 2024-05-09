
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _playerSpeed = 3.0f;
    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

         transform.Translate(Vector3.right * horizontalInput * _playerSpeed * Time.deltaTime);
         transform.Translate(Vector3.forward * verticalInput * _playerSpeed * Time.deltaTime);
        
       
    }
}
