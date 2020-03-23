using UnityEngine;

public class MouseInputController : MonoBehaviour, IMouseUserInput
{
    public bool SelectionButtonUp() => Input.GetMouseButtonUp(1);
    public Vector3 MousePosition() => Input.mousePosition;
}
