using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody player;
    [SerializeField] private Vector2 moveInput;
    [SerializeField] private float moveSpeed = 5f;


    private void Awake()
    {
        player = GetComponent<Rigidbody>();
    }

    public void OnMovement(InputAction.CallbackContext cntx)
    /*
    The functions is being read, but the player is moving by itself, the force is not being applied.
    When a key is pressed, it's read twice when pressed, and then again when unpressed.
    */
    {
        Debug.Log("Moving X-axis : " + cntx.phase);
        //player.AddForce(Vector3.right * Input.GetAxis("Horizontal") * 10f);
        //player.AddForce(new Vector3(10,0,0));
        moveInput = cntx.ReadValue<Vector2>();
    }

    private void Update()
    {
        player.linearVelocity = new Vector3((moveInput.x * moveSpeed), 0, 0);
    }

}
