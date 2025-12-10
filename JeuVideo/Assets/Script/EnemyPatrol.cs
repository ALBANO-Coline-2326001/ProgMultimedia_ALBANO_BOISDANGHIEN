using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform pointA; // Le point de départ
    public Transform pointB; // Le point d'arrivée
    public float speed = 2f; // Vitesse de déplacement

    private Transform currentTarget;

    void Start()
    {
        // On commence par aller vers le point B
        currentTarget = pointB;
    }

    void Update()
    {
        // Si on n'a pas défini de points, on ne fait rien
        if (pointA == null || pointB == null) return;

        // Déplacer l'ennemi vers la cible actuelle
        transform.position = Vector3.MoveTowards(transform.position, currentTarget.position, speed * Time.deltaTime);

        // Vérifier si on est arrivé (ou très proche) de la cible
        if (Vector3.Distance(transform.position, currentTarget.position) < 0.1f)
        {
            // Si on était en route vers B, on change pour A, et vice-versa
            if (currentTarget == pointB)
            {
                currentTarget = pointA;
                Flip(); // Optionnel : retourner le sprite
            }
            else
            {
                currentTarget = pointB;
                Flip(); // Optionnel : retourner le sprite
            }
        }
    }

    // Petite fonction pour retourner l'ennemi (surtout utile en 2D)
    void Flip()
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}