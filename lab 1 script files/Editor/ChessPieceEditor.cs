
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChessPieceSelect))]
public class ChessPieceEditor : Editor
{
    private void OnSceneGUI()
    {
        ChessPieceSelect piece = (ChessPieceSelect)target;
        Vector3 position = piece.transform.position;
        Handles.color = Color.white;

        piece.handlebordersize = Handles.ScaleValueHandle(
            piece.handlebordersize, 
            position + Vector3.right * piece.handlebordersize, 
            Quaternion.identity, 
            piece.handlebordersize, 
            Handles.CubeHandleCap, 
            0.1f
        );
        Handles.DrawWireCube(position, Vector3.one * piece.handlebordersize);
    }
}
