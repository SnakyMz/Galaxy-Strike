using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float controlSpeed = 50f;
    [SerializeField] float clampXRange = 20f;
    [SerializeField] float clampYRange = 15f;

    Vector2 movement;

    void Update()
    {
        ProcessTranslation();
    }

    private void ProcessTranslation()
    {
        float xOffset = movement.x * controlSpeed * Time.deltaTime;
        float rawXPos = transform.localPosition.x + xOffset;
        float clampedXPos = Mathf.Clamp(rawXPos, -clampXRange, clampXRange);

        float yOffset = movement.y * controlSpeed * Time.deltaTime;
        float rawYPos = transform.localPosition.y + yOffset;
        float clampedYPos = Mathf.Clamp(rawYPos, -clampYRange, clampYRange);

        transform.localPosition = new Vector3(clampedXPos, clampedYPos, 0f);
    }

    public void OnMove(InputValue value)
    {
        movement = value.Get<Vector2>();
    }
}
