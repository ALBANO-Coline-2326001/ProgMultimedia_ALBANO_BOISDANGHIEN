using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillableX : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {

        gameManager = FindObjectOfType<GameManager>();

        if (gameManager == null)
        {
            Debug.LogError("Le script GameManager n'a pas été trouvé dans la scène.");
        }
    }

    public void Kill()
    {
        Debug.Log("Killed");

        if (gameManager != null)
        {
            gameManager.EndGame();
        }

        gameObject.SetActive(false);


    }
}