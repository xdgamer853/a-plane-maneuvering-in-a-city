using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Score : MonoBehaviour
{
    public static Score Instance;
    public TextMeshProUGUI ScoreText;
    public int score;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        ScoreText.text = "Score: " + score;
    }
}
