using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManger : MonoBehaviour
{
    private bool gameHasEnded = false;
    private float restartDelay = 2f;
    public GameObject comepleteLevelText;
    public void endGame()
    {
        if (!gameHasEnded) {
            Debug.Log("Game Over My Friend");
            gameHasEnded = true;
            Invoke("restart",restartDelay);
        }

        
    }
    public void completeLevel()
    {
        comepleteLevelText.SetActive(true);
        Debug.Log("Level 1 completed");
    }
    void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
