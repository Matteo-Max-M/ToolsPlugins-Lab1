using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenPath : MonoBehaviour
{
      private void OnDrawGizmos()
    {
        
        if (!Application.isPlaying)
        {
            DrawQueenMovement();
        }
    }
    private void DrawQueenMovement()
    {
        Vector3 position = transform.position;
        Gizmos.color = Color.yellow;

        // Draw straight lines (like a Rook)
        for (int i = 1; i <= 8; i++) // Assuming a max range of 8 units (as per chessboard size)
        {
            Gizmos.DrawLine(position, position + new Vector3(0, 8, 0)); // Up
            Gizmos.DrawLine(position, position + new Vector3(0, -8, 0)); // Down
            Gizmos.DrawLine(position, position + new Vector3(-8, 0, 0)); // Left
            Gizmos.DrawLine(position, position + new Vector3(8, 0, 0)); // Right
        }

        // Draw diagonal lines (like a Bishop)
        for (int i = 1; i <= 8; i++) // Assuming a max range of 8 units (as per chessboard size)
        {
            Gizmos.DrawLine(position, position + new Vector3(-8, 8, 0)); // Top-left
            Gizmos.DrawLine(position, position + new Vector3(8, 8, 0)); // Top-right
            Gizmos.DrawLine(position, position + new Vector3(-8, -8, 0)); // Bottom-left
            Gizmos.DrawLine(position, position + new Vector3(8, -8, 0)); // Bottom-right
        }
    }
}
