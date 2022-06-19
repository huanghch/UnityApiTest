using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Vector3T : MonoBehaviour
{
    [MenuItem("Debug/Vector3/magnitude")]
    static void Magnitude()
    {
        float x = Vector3.Magnitude(new Vector3(1, 2, 3));
        Debug.Log("float x = Vector3.Magnitude(new Vector3(1, 2, 3)), x = " + x);
    }
    
    [MenuItem("Debug/Vector3/sqrMagnitude")]
    static void SqrMagnitude()
    {
        float x = Vector3.SqrMagnitude(new Vector3(1, 2, 3));
        Debug.Log("float x = Vector3.SqrMagnitude(new Vector3(1, 2, 3)), x = " + x);
    }
}
