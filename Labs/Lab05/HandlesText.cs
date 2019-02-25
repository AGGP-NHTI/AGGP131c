using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; 

public class HandlesText : MonoBehaviour
{
    public string text = "text"; 
    public Vector3 TextOffset = Vector3.zero; 
    
    void OnDrawGizmos()
    {
        Handles.Label(transform.position + TextOffset, text);
    }
}
