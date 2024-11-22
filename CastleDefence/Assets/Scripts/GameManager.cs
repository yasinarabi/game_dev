using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image[] lives;
    public Text scoreText;
    public int score = 0;
    public GameObject fireBall;
    public float minSpawnX = -5f, maxSpawnX = 5f;
    
    private int livesRemaining;

    
    void Start()
    {
        SpawmFireBall();
        livesRemaining = lives.Length;
    }

    void Update()
    {
        
    }
    private void SpawmFireBall(){
        Vector2 randomPosition = new Vector2(Random.Range(minSpawnX, maxSpawnX), 6);
        Instantiate(fireBall, randomPosition, Quaternion.Euler(new Vector3(0, 0, -90)));
    }

    public void DecreaseLife() {
        livesRemaining--;
        lives[livesRemaining].gameObject.SetActive(false);
        SpawmFireBall();
    }

    public void IncreaseScore() {
        score++;
        scoreText.text = "Score: " + score;
        SpawmFireBall();
    }
}
