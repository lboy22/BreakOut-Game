using UnityEngine;

public class BallMovement : MonoBehaviour
{

    [SerializeField] Rigidbody ballBody;
    [SerializeField] float minVelocity, maxVelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballBody = GetComponent<Rigidbody>();
        ballBody.linearVelocity = new Vector3(0, -minVelocity, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
