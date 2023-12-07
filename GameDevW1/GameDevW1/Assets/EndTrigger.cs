using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called before the first frame update
   public GameManager gameManager;
    void OnTriggerEntry()
    {
        gameManager.CompleteLevel();
    }
}
