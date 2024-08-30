using System.Collections;
using UnityEngine;

public class ChessGrid : MonoBehaviour
{
 private  float cellSize = 1f; 
 private  int gridSize = 8;  

    private void OnDrawGizmos()
    {
         
           Gizmos.color = Color.green;
        // Draw vertical lines
        for (int x = 0; x <= gridSize; x++)
        {
            Gizmos.DrawLine(new Vector3(x * cellSize, 0, 0), new Vector3(x * cellSize, gridSize * cellSize, 0));
        }

        // Draw horizontal lines
        for (int y = 0; y <= gridSize; y++)
        {
            Gizmos.DrawLine(new Vector3(0, y * cellSize, 0), new Vector3(gridSize * cellSize, y * cellSize, 0));
        }
    }
}
