using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 3; 
    private int currentHealth;

    void Start()
    {
        currentHealth = maxHealth; 
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
        Debug.Log("L'ennemi a pris des dégâts ! Vie restante : " + currentHealth);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("L'ennemi est mort !");
        Destroy(gameObject); 
    }
}