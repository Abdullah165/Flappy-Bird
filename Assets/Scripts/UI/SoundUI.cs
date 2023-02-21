using UnityEngine.UI;
using UnityEngine;

public class SoundUI : MonoBehaviour
{
    [SerializeField] Button toggleSoundButton;
    [SerializeField] Sprite soundOn;
    [SerializeField] Sprite soundOff;

    // Start is called before the first frame update
    void Start()
    {
        UpdateSoundIcon();
    }

    public void PauseSound()
    {
        MusicManager.Instance.ToggleSound();
        UpdateSoundIcon();
    }

    private void UpdateSoundIcon()
    {
        if(PlayerPrefs.GetInt(MusicManager.Instance.GetIsMusicPlaying()) == 0)
        {
            AudioListener.volume = 1;
            toggleSoundButton.GetComponent<Image>().sprite = soundOn;
        }
        else
        {
            AudioListener.volume = 0;
            toggleSoundButton.GetComponent<Image>().sprite = soundOff;
        }
    }
}
