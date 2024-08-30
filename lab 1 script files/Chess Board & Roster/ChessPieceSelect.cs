using System.Collections;

using UnityEngine;


[ExecuteInEditMode]
public class ChessPieceSelect : MonoBehaviour
{
 public enum ChessPieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
    }

    public ChessPieceType selectedPiece;// drop down list on inspector

    public GameObject pawnPrefab;
    public GameObject rookPrefab;
    public GameObject knightPrefab;
    public GameObject bishopPrefab;

    private GameObject[] pieces;
    public float handlebordersize= 1f;// white border size change in inspector

    private void Update()
    {
        if (!Application.isPlaying)
        {
            UpdateChessPiece();
        }
    }
private void Awake()
{
    pieces = new GameObject[] { pawnPrefab, rookPrefab, knightPrefab, bishopPrefab };
}


    private void UpdateChessPiece()
    {
        // checks if pieces[] contains any element or if its in use 
        if (pieces == null || pieces.Length == 0)
        {
            return;
        } 

        // Disable unselected pieces
        DisableAllPieces();

        // Enable the selected piece
        GameObject selectedPiecePrefab = GetPrefabForPiece(selectedPiece);
        if (selectedPiecePrefab != null)
        {
            selectedPiecePrefab.SetActive(true);
        }
    }
    private void DisableAllPieces()
    {
        foreach (var piece in pieces)
        {
            if (piece != null)
            {
                piece.SetActive(false);
            }
        }
    }

    private GameObject GetPrefabForPiece(ChessPieceType pieceType)
    {
        return pieceType switch
        {
            ChessPieceType.Pawn => pawnPrefab,
            ChessPieceType.Rook => rookPrefab,
            ChessPieceType.Knight => knightPrefab,
            ChessPieceType.Bishop => bishopPrefab,
            _ => null,
        };
    }
}



