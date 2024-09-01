using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnPath : MonoBehaviour
{
   private void OnDrawGizmos()
    {
        // Only draw gizmos if not playing
        if (!Application.isPlaying)
        {
            DrawPawnMovement();
        }
    }
    
      private void DrawPawnMovement()
    {
    Vector3 position = transform.position;
    Gizmos.color = Color.red;
    Gizmos.DrawLine(position, position + new Vector3(0, 1, 0)); // Forward move
    Gizmos.DrawLine(position, position + new Vector3(-1, 1, 0)); // Diagonal capture to the left
    Gizmos.DrawLine(position, position + new Vector3(1, 1, 0)); // Diagonal capture to the righ
    }

}
