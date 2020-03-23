using UnityEngine;

public class MainGameCamera : MonoBehaviour, IMainCamera
{
    Camera mainCamera;

    void Awake()
    {
        mainCamera = Camera.main;
    }

    public Ray ScreenPointToRay(Vector3 position) => mainCamera.ScreenPointToRay(position);
}
