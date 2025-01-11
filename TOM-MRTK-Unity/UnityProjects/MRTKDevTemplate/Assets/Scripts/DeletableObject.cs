using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletableObject : MonoBehaviour
{
    public string objectName; // Assign a unique name or ID in the Inspector

    void Start()
    {
        // Check if this object is marked as deleted
        if (ObjectStateManager.Instance != null && ObjectStateManager.Instance.IsDeleted(objectName))
        {
            Destroy(gameObject); // Destroy the object if it was previously deleted
        }
    }

    // Function to delete this object
    public void DeleteObject()
    {
        // Mark the object as deleted in the ObjectStateManager
        ObjectStateManager.Instance.MarkAsDeleted(objectName);

        // Destroy the object in the scene
        Destroy(gameObject);
    }
}
