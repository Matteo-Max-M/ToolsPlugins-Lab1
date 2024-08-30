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
        Queen,
        King,
    }

    public enum tint
    {
        Blacktint,
        Whitetint,
    }

    public ChessPieceType selectedPiece; // drop down list in inspector
    public tint tintedPiece = tint.Whitetint; // default tint state

    public GameObject pawnPrefab;
    public GameObject rookPrefab;
    public GameObject knightPrefab;
    public GameObject bishopPrefab;
    public GameObject QueenPrefab;
    public GameObject KingPrefab;

    private GameObject[] pieces;
    public float handlebordersize = 1f;

    void Awake()
    {
        pieces = new GameObject[] { pawnPrefab, rookPrefab, knightPrefab, bishopPrefab, QueenPrefab, KingPrefab };
        UpdateChessPiece(); 
    }

    void OnValidate()
    {
        UnityEditor.EditorApplication.delayCall += UpdateChessPiece; 
    }

    private void UpdateChessPiece()
    {
        if (pieces == null || pieces.Length == 0) 
            return;

        foreach (var piece in pieces)
        {
            if (piece != null)
            {
                piece.SetActive(piece == GetPrefabForPiece(selectedPiece));
            }
        }
    }

    public GameObject GetPrefabForPiece(ChessPieceType pieceType)
    {
        return pieceType switch
        {
            ChessPieceType.Pawn => pawnPrefab,
            ChessPieceType.Rook => rookPrefab,
            ChessPieceType.Knight => knightPrefab,
            ChessPieceType.Bishop => bishopPrefab,
            ChessPieceType.Queen => QueenPrefab,
            ChessPieceType.King => KingPrefab,
            _ => null,
        };
    }
}




