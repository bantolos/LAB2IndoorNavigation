using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnvironmentRotation : MonoBehaviour
{
    [SerializeField]
    NavMeshSurface navMeshSurface;
    public Transform Environment;
    public Quaternion startQuaternion;
    void start()
    {
        NavMeshBake();
    }
    public void rotateLeft()
    {
        Vector3 rotationToAdd = new Vector3(0, 2.5f, 0);
        Environment.Rotate(rotationToAdd);
        NavMeshBake();
    }

    public void rotateRight()
    {
        Vector3 rotationToAdd = new Vector3(0, -2.5f, 0);
        Environment.Rotate(rotationToAdd);
        NavMeshBake();
    }

    public void NavMeshBake()
    {
        navMeshSurface.BuildNavMesh();
    }
}