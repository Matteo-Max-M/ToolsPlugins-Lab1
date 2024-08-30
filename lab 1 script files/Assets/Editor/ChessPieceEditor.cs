using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(ChessPieceSelect))]
public class ChessPieceEditor : Editor
{
    private void OnSceneGUI()
    {
        ChessPieceSelect piece = (ChessPieceSelect)target;
        Vector3 position = piece.transform.position;

        /// tint switcher
        GameObject activePrefab = piece.GetPrefabForPiece(piece.selectedPiece);
        if (activePrefab != null)
        {
            SpriteRenderer spriteRenderer = activePrefab.GetComponent<SpriteRenderer>();
            if (spriteRenderer != null)
            {
               // Adjusting opacity
            Color baseColor = piece.tintedPiece == ChessPieceSelect.tint.Whitetint ? Color.white : Color.black;
            Color tintColor = new Color(baseColor.r, baseColor.g, baseColor.b, 0.9f);
            
            // Apply the color with adjusted opacity
            spriteRenderer.color = tintColor;
            }
        } 
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
