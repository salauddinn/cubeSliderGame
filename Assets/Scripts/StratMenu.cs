using UnityEngine;
using UnityEngine.SceneManagement;

public class StratMenu : MonoBehaviour
{
  public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
