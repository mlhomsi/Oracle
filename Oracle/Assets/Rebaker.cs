using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Rebaker : MonoBehaviour
{
    public NavMeshSurface Surface;

    void Start()
    {
        Surface.BuildNavMesh();
    }
}