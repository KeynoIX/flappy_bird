using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        Debug.Log("New score: " + score);
    }
}
