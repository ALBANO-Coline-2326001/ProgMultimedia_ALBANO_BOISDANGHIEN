using UnityEngine;

public class WeaponPickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerShooting shootingScript = other.GetComponent<PlayerShooting>();

            if (shootingScript != null)
            {
                shootingScript.EquipGun(); 
                Destroy(gameObject);       
            }
        }
    }
}