using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Transform firePoint;      
    public GameObject bulletPrefab;  
    public GameObject gunInHand;     

    private bool hasWeapon = false;  

    void Update()
    {
        if (hasWeapon && Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    public void EquipGun()
    {
        hasWeapon = true;
        gunInHand.SetActive(true); 
    }
}