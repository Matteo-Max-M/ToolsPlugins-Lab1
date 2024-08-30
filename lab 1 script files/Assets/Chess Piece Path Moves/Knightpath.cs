using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knightpath : MonoBehaviour
{
      private void OnDrawGizmos()
    {
        
        if (!Application.isPlaying)
        {
            DrawKnightMovement();
        }
    }
    private void DrawKnightMovement()
{
    Vector3 position = transform.position;
    Gizmos.color = Color.magenta;

    // The knight moves in an L-shape. These are the 8 possible moves.
    Gizmos.DrawLine(position, position + new Vector3(2, 1, 0)); // Move two squares right, one square up
    Gizmos.DrawLine(position, position + new Vector3(2, -1, 0)); // Move two squares right, one square down
    Gizmos.DrawLine(position, position + new Vector3(-2, 1, 0)); // Move two squares left, one square up
    Gizmos.DrawLine(position, position + new Vector3(-2, -1, 0)); // Move two squares left, one square down
    Gizmos.DrawLine(position, position + new Vector3(1, 2, 0)); // Move one square right, two squares up
    Gizmos.DrawLine(position, position + new Vector3(1, -2, 0)); // Move one square right, two squares down
    Gizmos.DrawLine(position, position + new Vector3(-1, 2, 0)); // Move one square left, two squares up
    Gizmos.DrawLine(position, position + new Vector3(-1, -2, 0)); // Move one square left, two squares down
}
}
