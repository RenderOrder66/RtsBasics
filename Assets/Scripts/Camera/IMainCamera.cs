using UnityEngine;

interface IMainCamera
{
    Ray ScreenPointToRay(Vector3 position);
}
