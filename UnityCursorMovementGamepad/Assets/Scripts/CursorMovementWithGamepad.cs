using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class CursorMovementWithGamepad : MonoBehaviour
{
    [SerializeField] private Vector2 sensitivity; //sensitivity values
    [SerializeField] private Vector2 cursorAdjutment; //cursor adjustment valeus
    private Vector2 mousePosition; //current mouse position
    private Vector2 warpPosition; //position of the cursor to warp
    private Vector2 cursorPrecision; //precision of the cursor
    private CursorInput cursorInput; //our cursor input actions

    private void Start()
    {
        cursorInput = new CursorInput(); //creating a new cursor input
        cursorInput.Enable(); //we enable it
        sensitivity = new Vector2(1500f, 1500f); //we set the default sentivity
        cursorAdjutment = new Vector2(0f, -1f); //set the default cursor adjustment
    }

    private void Update()
    {

        var cursorActions = cursorInput.GamepadStick; //getting the gamepad stick actions from the cursor inptu
        Vector2 moveInput = cursorActions.LeftControllerStick.ReadValue<Vector2>();//read the left stick input
        MoveCursor(moveInput); //move the cursor with our input
    }

    private void MoveCursor(Vector2 moveInput)
    {
        //current mouse position
        mousePosition = Mouse.current.position.ReadValue();

        //value for the desired mouse position
        warpPosition = mousePosition + cursorAdjutment + cursorPrecision + sensitivity * Time.deltaTime * moveInput;

        //keep the cursor inside the game screen and not anywhere else
        warpPosition = new Vector2(Mathf.Clamp(warpPosition.x, 0, Screen.width), Mathf.Clamp(warpPosition.y, 0, Screen.height));

        //cursor position for a more precise position
        cursorPrecision = new Vector2(warpPosition.x % 1, warpPosition.y % 1);

        //move the cursor
        Mouse.current.WarpCursorPosition(warpPosition);
    }
}
