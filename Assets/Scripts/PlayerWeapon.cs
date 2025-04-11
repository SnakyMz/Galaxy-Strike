using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnFire(InputValue value)
    {
        Debug.Log("Fire");
    }
}
