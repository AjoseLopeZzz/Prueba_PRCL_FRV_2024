using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public InputActionProperty leftDesactivate;
    public InputActionProperty rightDesactivate;

    public XRRayInteractor leftRay;
    public XRRayInteractor rightRay;

    void Update()
    {
        bool isleftRayHovering = leftRay.TryGetHitInfo(out Vector3 leftpos, out Vector3 leftnomal, out int leftnumber, out bool leftValid);
        leftTeleportation.SetActive(isleftRayHovering && leftDesactivate.action.ReadValue<float>() == 0 && leftActivate.action.ReadValue<float>()> 0.1f);
        bool isrightRayHovering = rightRay.TryGetHitInfo(out Vector3 rightpos, out Vector3 rightnomal, out int rightnumber, out bool rightValid);
        rightTeleportation.SetActive(isrightRayHovering && rightDesactivate.action.ReadValue<float>() == 0 && rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
