using UnityEngine; 
using UnityEngine.InputSystem;

public class inputManager : MonoBehaviour
{
    public static Vector2 Movement; //the movement vector (static = available from other instances(e.g. other scripts))
    public PlayerInput _playerInput; //the PlayerInput component
    public InputAction moveAction; //the movement direction action

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
        moveAction = _playerInput.actions["Movement"];
    }
    private void Update()
    {
        Movement = moveAction.ReadValue<Vector2>();
    }
}
