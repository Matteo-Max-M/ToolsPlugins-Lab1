using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookPath : MonoBehaviour
{
     private void OnDrawGizmos()
    {
        // Only draw gizmos if not playing
        if (!Application.isPlaying)
        {
            DrawRookMovement();
        }
    }
    
  private void DrawRookMovement()
    {
    Vector3 position = transform.position;
    Gizmos.color = Color.blue;

    // Vertical moves
    Gizmos.DrawLine(position, position + new Vector3(0, 5, 0)); // Forward
    Gizmos.DrawLine(position, position + new Vector3(0, -5, 0)); // Backward

    // Horizontal moves
    Gizmos.DrawLine(position, position + new Vector3(-5, 0, 0)); // Left
    Gizmos.DrawLine(position, position + new Vector3(5, 0, 0)); // Right
    }

}
