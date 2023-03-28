using UnityEngine;
using UnityEngine.InputSystem;

public class MoverScript : MonoBehaviour
{

    public float speed = 5f;
    public InputAction moveUp = new InputAction(type: InputActionType.Button);
    public InputAction moveDown = new InputAction(type: InputActionType.Button);
    public InputAction moveRight = new InputAction(type: InputActionType.Button);
    public InputAction moveLeft = new InputAction(type: InputActionType.Button);


    // Start is called before the first frame update
    void Start()
    {
        moveUp.Enable();
        moveDown.Enable();
        moveLeft.Enable();
        moveRight.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (moveUp.IsPressed())
        {
            transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
        }
        if (moveDown.IsPressed())
        {
            transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
        }
        if (moveRight.IsPressed())
        {
            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
        }
        if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;
        }




    }
}
