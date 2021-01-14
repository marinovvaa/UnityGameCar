using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    //public float smoothSpeed = 0.125f;
    public Vector3 offset;
    void Update()
    {
        LateUpdate();
    }
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
