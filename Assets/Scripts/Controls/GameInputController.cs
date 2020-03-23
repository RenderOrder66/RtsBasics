using System.Linq;
using UnityEngine;

public class GameInputController : MonoBehaviour
{
    public VectorEvent onPress;
    IMouseUserInput mouseInput;

    void Awake()
    {
        var components = GetComponents<MonoBehaviour>();
        mouseInput = (IMouseUserInput)components.FirstOrDefault(x => x is IMouseUserInput);
    }

    void Update()
    {
        if (!mouseInput.SelectionButtonUp()) return;
        onPress?.Invoke(mouseInput.MousePosition());
    }
}
