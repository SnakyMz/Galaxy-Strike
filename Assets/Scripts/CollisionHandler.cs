using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject playerDestroyedVFX;

    GameSceneManager gameSceneManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameSceneManager = FindFirstObjectByType<GameSceneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        gameSceneManager.ReloadLevel();
        Instantiate(playerDestroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
