using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance { get; private set; }

    private const string IS_MUSIC_PLAYING = "IsMusicPlaying";

    private void Awake()
    {
        Instance = this;
    }

    public void ToggleSound()
    {
        if (PlayerPrefs.GetInt(IS_MUSIC_PLAYING) == 0)
        {
            PlayerPrefs.SetInt(IS_MUSIC_PLAYING, 1);
        }
        else
        {
            PlayerPrefs.SetInt(IS_MUSIC_PLAYING, 0);
        }
    }

    public string GetIsMusicPlaying()
    {
        return IS_MUSIC_PLAYING;
    }
}
