using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int targetScore = 20;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    public TextMeshProUGUI loseText;
    public TextMeshProUGUI restartText;

    private bool gameEnded = false;

    void Start()
    {
        winText.gameObject.SetActive(false);
        loseText.gameObject.SetActive(false);
        restartText.gameObject.SetActive(false);
        UpdateScoreUI();
    }

    void Update()
    {
        if (gameEnded && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddScore(int amount)
    {
        if (gameEnded) return;

        score += amount;
        UpdateScoreUI();

        if (score >= targetScore)
        {
            WinGame();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + score;
    }

    void WinGame()
    {
        gameEnded = true;
        winText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoseGame()
    {
        if (gameEnded) return;

        gameEnded = true;
        loseText.gameObject.SetActive(true);
        restartText.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}