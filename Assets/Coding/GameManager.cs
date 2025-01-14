using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int score;
    public Button restartButton;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        Time.timeScale = 0f;
        restartButton.onClick.AddListener(RestartGame);
        restartButton.gameObject.SetActive(false);
    }

    void RestartGame()
    {
        SceneManager.LoadScene("Flappy Bird");
    }

    public void killPlayer()
    {
        OnPlayerDie();
    }

    void OnPlayerDie()
    {
        Time.timeScale = 0f;
        restartButton.gameObject.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1f;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Flappy Bird");
        }
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        Debug.Log("New score: " + score);
    }
}