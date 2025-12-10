using UnityEngine;

public class Piece : MonoBehaviour
{
    public float vitesseRotation = 100f;

    public AudioClip sonRamassage;

    [Range(0f, 1f)]
    public float volumeSon = 1f;

    void Update()
    {
        transform.Rotate(0, vitesseRotation * Time.deltaTime, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            JoueurInventaire inventaire = other.GetComponent<JoueurInventaire>();

            if (inventaire != null)
            {
                inventaire.AjouterPiece();
            }

            if (sonRamassage != null)
            {
                AudioSource.PlayClipAtPoint(sonRamassage, transform.position, volumeSon);
            }

            Destroy(gameObject);
        }
    }
}