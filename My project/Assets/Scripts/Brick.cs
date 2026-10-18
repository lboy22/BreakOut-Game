using UnityEngine;

public class Brick : MonoBehaviour
{
    public void OnTouch()
    {
        Debug.Log(this.name  + " touched.");
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            OnTouch();
        }
        else{Debug.Log("Not touched by ball.");}
    }
}
