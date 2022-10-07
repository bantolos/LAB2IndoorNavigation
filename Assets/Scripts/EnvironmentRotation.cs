using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnvironmentRotation : MonoBehaviour
{
    [SerializeField]
    NavMeshSurface[] navMeshSurface;
    public Transform Environment;
    public Quaternion startQuaternion;
    void Start()
    {
        NavMeshBake();
    }
    public void rotateLeft()
    {
        Vector3 rotationToAdd = new Vector3(0, 1f, 0);
        Environment.Rotate(rotationToAdd);
        // NavMeshBake();
    }

    public void rotateRight()
    {
        Vector3 rotationToAdd = new Vector3(0, -1f, 0);
        Environment.Rotate(rotationToAdd);
        // NavMeshBake();
    }

    public void NavMeshBake()
    {
        for (int i = 0; i < navMeshSurface.Length; i++)
        {
            navMeshSurface[i].BuildNavMesh();
        }
        // navMeshSurface.BuildNavMesh();
    }
}
