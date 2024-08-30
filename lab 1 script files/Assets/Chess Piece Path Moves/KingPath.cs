using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingPath : MonoBehaviour
{

      private void OnDrawGizmos()
    {
        
        if (!Application.isPlaying)
        {
            DrawKingMovement();
        }
    }
    private void DrawKingMovement()
    {
    Vector3 position = transform.position;
    Gizmos.color = Color.yellow;

    // All 8 possible moves
    Gizmos.DrawLine(position, position + new Vector3(0, 1, 0)); // Up
    Gizmos.DrawLine(position, position + new Vector3(0, -1, 0)); // Down
    Gizmos.DrawLine(position, position + new Vector3(-1, 0, 0)); // Left
    Gizmos.DrawLine(position, position + new Vector3(1, 0, 0)); // Right
    Gizmos.DrawLine(position, position + new Vector3(-1, 1, 0)); // Top-left
    Gizmos.DrawLine(position, position + new Vector3(1, 1, 0)); // Top-right
    Gizmos.DrawLine(position, position + new Vector3(-1, -1, 0)); // Bottom-left
    Gizmos.DrawLine(position, position + new Vector3(1, -1, 0)); // Bottom-right
    }
}
