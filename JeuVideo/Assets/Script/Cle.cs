using UnityEngine;

public class Cle : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip sonCle;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            JoueurInventaire inventaire = other.GetComponent<JoueurInventaire>();

            if (inventaire != null)
            {
                inventaire.RecupererCle(); 

                if (sonCle != null)
                {
                    AudioSource.PlayClipAtPoint(sonCle, transform.position);
                }

                Debug.Log("Clé récupérée !");
                Destroy(gameObject);
            }
        }
    }
}