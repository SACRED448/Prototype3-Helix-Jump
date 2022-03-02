using System.Collections;
using UnityEngine;

public class Ring : MonoBehaviour
{
    private Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > player.position.y)
        {
            GameManager.score++;
            GameManager.numberOfPassedRings++;
            FindObjectOfType<AudioManager>().Play("Whoosh");
            StartCoroutine(DestroyCouroitine());
        }
    }

    private IEnumerator DestroyCouroitine()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
