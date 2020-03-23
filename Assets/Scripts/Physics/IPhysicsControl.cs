using UnityEngine;

public interface IPhysicsControl
{
    bool RayCastHit(Ray ray, out RaycastHit info, float maxDistance);
}
