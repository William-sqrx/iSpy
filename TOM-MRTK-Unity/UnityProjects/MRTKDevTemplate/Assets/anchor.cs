using System.Collections;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Utilities.Solvers;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    public Transform anchorTransform;
    void Start()
    {
        if (anchorTransform != null)
        {
            // Reset position relative to the camera
            transform.position = anchorTransform.position;
            // transform.eulerAngles = Vector3.up * anchorTransform.eulerAngles.y;
            transform.rotation = anchorTransform.rotation;
        }
    }
}
