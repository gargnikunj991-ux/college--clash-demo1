using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public TextMeshProUGUI timerText;

    bool timerRunning = true;
    ScoreManager scoreManager;

    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();
        UpdateTimerUI();
    }
    private void Awake()
    {
        Time.timeScale = 1.0f;
    }

    void Update()
    {
        if (!timerRunning) return;

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();
        }
        else
        {
            timeRemaining = 0;
            timerRunning = false;
            UpdateTimerUI();

            ScoreManager sm =
            FindObjectOfType<ScoreManager>();
            if (sm != null)
            {
                sm.LoseGame();
            }
        }
    }
   

    void UpdateTimerUI()
    {
        timerText.text = "Time: " + Mathf.Ceil(timeRemaining).ToString();
    }
}