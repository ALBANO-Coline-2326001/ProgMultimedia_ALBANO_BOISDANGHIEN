using UnityEngine;
using UnityEngine.SceneManagement; 

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void EndGame()
    {
        gameOverScreen.SetActive(true);

        Time.timeScale = 0f;

        Debug.Log("Game Over affiché.");
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}