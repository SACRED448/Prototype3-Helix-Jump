using UnityEngine;
using System.Collections;

public class DestroyChunk : MonoBehaviour
{
    [SerializeField] private Rigidbody[] chunks;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(DestroyCouroitine());
        }
    }

    private IEnumerator DestroyCouroitine()
    {
        foreach (var item in chunks)
        {
            yield return new WaitForSeconds(0.1f);
            item.useGravity = true;
        }

        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
