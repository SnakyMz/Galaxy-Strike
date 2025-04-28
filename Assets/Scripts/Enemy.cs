using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject destroyedVFX;
    [SerializeField] int hitpoints = 4;
    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        hitpoints--;

        if (hitpoints <= 0)
        {
            Instantiate(destroyedVFX, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
