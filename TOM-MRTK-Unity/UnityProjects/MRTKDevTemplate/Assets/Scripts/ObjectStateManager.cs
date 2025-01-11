using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStateManager : MonoBehaviour
{
    public static ObjectStateManager Instance;

    // A dictionary to track deleted objects by their names or IDs
    private HashSet<string> deletedObjects = new HashSet<string>();

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
        }
        else
        {
            Destroy(gameObject);


        }
        DontDestroyOnLoad(gameObject);
    }

    // Mark an object as deleted
    public void MarkAsDeleted(string objectName)
    {
        deletedObjects.Add(objectName);
    }

    // Check if an object is marked as deleted
    public bool IsDeleted(string objectName)
    {
        return deletedObjects.Contains(objectName);
    }

    // Clear the state when you want to reset everything
    public void ResetState()
    {
        deletedObjects.Clear();
    }
}
