using UnityEngine;

public class Teleporteur : MonoBehaviour
{
    public Transform pointDeDestination;
    public ParticleSystem effetParticules;

    public AudioClip sonTeleportation;

    [Range(0f, 1f)]
    public float volumeSon = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TeleporterJoueur(other.gameObject);
        }
    }

    void TeleporterJoueur(GameObject joueur)
    {
        if (sonTeleportation != null)
        {
            AudioSource.PlayClipAtPoint(sonTeleportation, transform.position,volumeSon);
        }

        CharacterController cc = joueur.GetComponent<CharacterController>();
        if (cc != null) cc.enabled = false;

        joueur.transform.position = pointDeDestination.position;
        joueur.transform.rotation = pointDeDestination.rotation;

        if (cc != null) cc.enabled = true;
    }
}