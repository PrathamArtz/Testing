
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _playerSpeed = 3.0f;
    [SerializeField] private float _jumpForce = 10.0f;


    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        float jumpInput = Input.GetAxis("Jump");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * _playerSpeed * Time.deltaTime);

        transform.Translate(Vector3.up * jumpInput * _jumpForce * Time.deltaTime);
    }
}
