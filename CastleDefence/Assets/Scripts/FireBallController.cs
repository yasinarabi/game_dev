using UnityEngine;

public class FireBallController : MonoBehaviour
{
    
    private GameManager gameManager;  //Reference to the GameManager to handle life
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameManager == null) {
        gameManager = FindFirstObjectByType<GameManager>();
        if (gameManager == null) {
            Debug.LogError("GameManager not found in the scene!");
        }
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // This function is triggered when the collectible collides with any object
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Ground"))
        {
            gameManager.DecreaseLife();
        }
        if (collider.gameObject.CompareTag("Player"))
        {
            gameManager.IncreaseScore();
        }
        Destroy(gameObject);
    }
}
