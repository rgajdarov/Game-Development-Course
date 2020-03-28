using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
    public Transform followee;

    public Vector3 cameraOffset;

    void LateUpdate()
    {
        transform.position = followee.position + cameraOffset;

        transform.LookAt(followee.position);
    }
}
