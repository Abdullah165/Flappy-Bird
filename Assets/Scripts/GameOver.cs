using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] GameObject gameOver;
    [SerializeField] AudioSource audio;

 
    private void Start()
    {
        gameOver.SetActive(false);
        Bird.Instance.OnGameOver += Instance_OnGameOver;
    }

    private void Instance_OnGameOver(object sender, System.EventArgs e)
    {
        audio.Play();
        gameOver.SetActive(true);
        Bird.Instance.SetFlapStrength(0f);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver.SetActive(false);
    }
}
