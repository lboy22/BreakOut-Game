using UnityEngine;

public class Player : MonoBehaviour
{
[SerializeField] private Rigidbody player;


private void Awake()
    {
        player = GetComponent<Rigidbody>();
    }

    public void Movement()
    /*
    The functions is being read, but the player is moving by itself, the force is not being applied.
    When a key is pressed, it's read twice when pressed, and then again when unpressed.
    */
    {
        Debug.Log("Moving X-axis");
        player.AddForce(Vector3.right * Input.GetAxis("Horizontal") * 10f);
    }


}
