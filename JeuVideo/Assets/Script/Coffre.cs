using UnityEngine;

public class Coffre : MonoBehaviour
{
    public GameObject visuelCoffreFerme;
    public GameObject visuelCoffreOuvert;

    private GameManager gameManager;

    public AudioClip sonOuverture;

    private bool estOuvert = false;

    [Range(0f, 1f)]
    public float volumeSon = 1f;

    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        if (visuelCoffreOuvert != null) visuelCoffreOuvert.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !estOuvert)
        {
            JoueurInventaire inventaire = other.GetComponent<JoueurInventaire>();

            if (inventaire != null && inventaire.aLaCle == true)
            {
                OuvrirCoffre();
            }
            else
            {
                Debug.Log("Il vous faut la clé !");
            }
        }
    }

    void OuvrirCoffre()
    {
        estOuvert = true;
        Debug.Log("Coffre ouvert !");
        if (sonOuverture != null)
        {
            Debug.Log("Lecture du son d'ouverture du coffre.");
            AudioSource.PlayClipAtPoint(sonOuverture, transform.position, volumeSon);
        }
        if (gameManager != null)
        {
            gameManager.Victory();
        }

        if (visuelCoffreFerme != null) visuelCoffreFerme.SetActive(false);
        if (visuelCoffreOuvert != null) visuelCoffreOuvert.SetActive(true);
    }
}