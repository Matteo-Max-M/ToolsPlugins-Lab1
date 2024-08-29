using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopPath : MonoBehaviour
{
      private void OnDrawGizmos()
    {
        
        if (!Application.isPlaying)
        {
            DrawBishopMovement();
        }
    }
    
    private void DrawBishopMovement()
    {
    Vector3 position = transform.position;
    Gizmos.color = Color.magenta;

    // Diagonal moves
    Gizmos.DrawLine(position, position + new Vector3(-5, 5, 0)); // Top-left
    Gizmos.DrawLine(position, position + new Vector3(5, 5, 0)); // Top-right
    Gizmos.DrawLine(position, position + new Vector3(-5, -5, 0)); // Bottom-left
    Gizmos.DrawLine(position, position + new Vector3(5, -5, 0)); // Bottom-right
    }
}
