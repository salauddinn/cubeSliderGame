using UnityEngine;

public class PlayerCollison : MonoBehaviour
{
    private const string OBSTACLE = "obstacle";
    public PlayerMovement movement;
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == OBSTACLE) {
            movement.enabled = false;
            FindObjectOfType<GameManger>().endGame();
        }
    }
}
