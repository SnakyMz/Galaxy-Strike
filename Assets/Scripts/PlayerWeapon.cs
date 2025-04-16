using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    bool isFiring = false;
    
    // Update is called once per frame
    void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    void ProcessFiring()
    {
        if (isFiring)
        {
            Debug.Log("Fire");
        }
    }
}
