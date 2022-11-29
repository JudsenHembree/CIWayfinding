using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class mover : MonoBehaviour
{
    public SteamVR_Action_Vector2 touchpadInput;
    public Transform cameraTransform;
    private CapsuleCollider capsuleCollider;
    // Start is called before the first frame update
    void Start()
    {
        capsuleCollider = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    private void FixedUpdate() {
        Vector3 movement = Player.instance.hmdTransform.TransformDirection(new Vector3(touchpadInput.axis.x,0,touchpadInput.axis.y));
        transform.position += Vector3.ProjectOnPlane(Time.deltaTime * movement * 2.0f, Vector3.up);

        float distanceFromFloor = Vector3.Dot(cameraTransform.localPosition, Vector3.up);
        capsuleCollider.height = Mathf.Max(capsuleCollider.radius, distanceFromFloor);

        capsuleCollider.center = cameraTransform.localPosition - 0.5f * distanceFromFloor * Vector3.up;
    }
}
