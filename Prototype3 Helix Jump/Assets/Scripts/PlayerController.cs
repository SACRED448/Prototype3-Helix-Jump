using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRB;
    public float bounForce = 6f;


    private void OnCollisionEnter(Collision collision)
    {
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounForce, playerRB.velocity.z);
    }
}
