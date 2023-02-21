using UnityEngine.UI;
using UnityEngine;

public class PlayerScoreUI : MonoBehaviour
{
    int score;
    [SerializeField] Text scoreText;

    private void Start()
    {
        Bird.Instance.OnScoreChanged += Instance_OnScoreChanged;
    }

    private void Instance_OnScoreChanged(object sender, System.EventArgs e)
    {
        score++;
        scoreText.text = score.ToString();
    }
}
