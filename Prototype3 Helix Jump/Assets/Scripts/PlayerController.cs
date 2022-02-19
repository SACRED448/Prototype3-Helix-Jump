using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRB;
    public float bounForce = 6f;

    private AudioManager audioManager;

    void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        audioManager.Play("Bounce");
        playerRB.velocity = new Vector3(playerRB.velocity.x, bounForce, playerRB.velocity.z);
        string materialName = collision.transform.GetComponent<MeshRenderer>().material.name;


        if (materialName == "Safe (Instance)")
        {
            //The ball hits the safe area
        } else if (materialName == "Unsafe (Instance)")
        {
            //The ball hits the unsafe area
            GameManager.gameOver = true;
            audioManager.Play("Game Over");
        } else if (materialName == "LastRing (Instance)" && !GameManager.levelCompleted)
        {
            //We completed the Level
            GameManager.levelCompleted = true;
            audioManager.Play("Win Level");
        }

    }
    
}
