using System.Collections;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI gameoverText;
    [SerializeField] GameObject gameoverPanel;
    [SerializeField] GameObject leftButton;
    [SerializeField] GameObject rightButton;

    private IEnumerator Coroutine;

    private void Start()
    {
        Coroutine = Scoring(2);
        StartCoroutine(Coroutine);
    }

    private IEnumerator Scoring(int wait)
    {
        while (true)
        {
            yield return new WaitForSeconds(wait);
            score++;
            scoreText.text = $"{score}";
        }
          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score += 5;
            scoreText.text = $"{score}";
        }
        if (collision.gameObject.tag == "ObstacleCar")
        {
            Time.timeScale = 0;
            gameoverPanel.SetActive(true);
            scoreText.text = "";
            gameoverText.text = $"Your score : {score}";
            leftButton.SetActive(false);
            rightButton.SetActive(false);
        }
    }
}
