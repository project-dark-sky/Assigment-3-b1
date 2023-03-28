
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatorScript : MonoBehaviour
{
    public float speed = 1;
    public InputAction rotateRight = new InputAction(type: InputActionType.Button);
    public InputAction rotateLeft = new InputAction(type: InputActionType.Button);
    private float rotZ;

    // Start is called before the first frame update
    void Start()
    {
        rotateRight.Enable();
        rotateLeft.Enable();
        rotZ = transform.rotation.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateRight.IsPressed())
        {
            rotZ -= Time.deltaTime * speed;
        }
        else if (rotateLeft.IsPressed())
        {
            rotZ += Time.deltaTime * speed;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
