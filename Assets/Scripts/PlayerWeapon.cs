using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject laser; 
    
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
        var emissionModule = laser.GetComponent<ParticleSystem>().emission;

        emissionModule.enabled = isFiring;
    }
}
