using UnityEngine;
using TMPro;   

public class JoueurInventaire : MonoBehaviour
{
    [Header("Données")]
    public int nbPieces = 0;
    public bool aLaCle = false;
    public TextMeshProUGUI textePiecesUI; 
    public TextMeshProUGUI texteCleUI; 

    void Start()
    {
        MettreAJourUI();
    }

    public void AjouterPiece()
    {
        nbPieces++; 
        MettreAJourUI();
    }

    public void RecupererCle()
    {
        aLaCle = true;
        MettreAJourUI();
    }

    void MettreAJourUI()
    {
        if (textePiecesUI != null)
        {
            textePiecesUI.text = "Pièces : " + nbPieces.ToString();
        }

        if (texteCleUI != null)
        {
            texteCleUI.text = aLaCle ? "Clé récupérée" : "Clé non récupérée";
        }
    }
}