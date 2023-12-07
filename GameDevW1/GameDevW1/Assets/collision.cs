
using UnityEngine;

public class collision : MonoBehaviour
{
    public movementplayer movement;

    void OnCollisionEnter (Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
