using UnityEngine;

public class PhysicsControl : MonoBehaviour, IPhysicsControl
{
    public bool RayCastHit(Ray ray, out RaycastHit info, float maxDistance) =>
        Physics.Raycast(ray, out info, maxDistance);
}
