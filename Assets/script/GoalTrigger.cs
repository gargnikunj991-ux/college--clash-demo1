using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;
    public int scoreValue = 1;

    void Start()
    {
        scoreManager = FindFirstObjectByType<ScoreManager>();

        if (scoreManager == null)
            Debug.LogError("ScoreManager NOT FOUND");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            scoreManager.AddScore(scoreValue);
        }
    }
}