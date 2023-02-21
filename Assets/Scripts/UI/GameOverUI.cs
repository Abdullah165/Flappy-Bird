using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    Bird bird;

    private void Start()
    {
        gameOver.SetActive(false);
        bird = GetComponent<Bird>();
        Bird.Instance.OnGameOver += Instance_OnGameOver;
    }

    private void Instance_OnGameOver(object sender, System.EventArgs e)
    {
        gameOver.SetActive(true);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.CompareTag("Pipe"))
    //    {
    //        gameOver.SetActive(true);
    //        //bird.flapStrength = 0f;
    //    }
    //    else
    //    {
    //        PlayAgain();
    //    }
    //}

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOver.SetActive(false);
    }
}
