using System.Linq;
using UnityEngine;
using UnityEngine.AI;

public class MousePointToDestination : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    IMainCamera mainCamera;
    IPhysicsControl physicsControl;

    void Awake()
    {
        var components = GetComponents<MonoBehaviour>();
        mainCamera = (IMainCamera)components.FirstOrDefault(x => x is IMainCamera);
        physicsControl = (IPhysicsControl)components.FirstOrDefault(x => x is IPhysicsControl);
    }

    public void SetAgentDestination(Vector3 destination)
    {
        if (!physicsControl.RayCastHit(mainCamera.ScreenPointToRay(destination), out var hit, 100)) return;

        agent.destination = hit.point;
    }
}
