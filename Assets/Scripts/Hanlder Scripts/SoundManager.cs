using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //private bool isMuted;
    [SerializeField] Image muteIcon;
    [SerializeField] Image unmuteIcon;
    private bool muted = false;

    void Start()
    {
        if (PlayerPrefs.HasKey("muted"))
        {
            PlayerPrefs.SetInt("muted", 0);
            Load();
        }
        else
        {
            Load();
        }
        UpdateButtonIcon();
        AudioListener.pause = muted;
    }

    public void OnButtonPress()
    {
        if (muted == false)
        {
            muted = true;
            AudioListener.pause = true;
        }
        else
        {
            muted = false;
            AudioListener.pause = false;
        }
        Save();
        UpdateButtonIcon();
    }
    private void UpdateButtonIcon()
    {
        if (muted == false)
        {
            unmuteIcon.enabled = true;
            muteIcon.enabled = false;
        }
        else
        {
            unmuteIcon.enabled = false;
            muteIcon.enabled = true;
        }
        Save();
    }
    private void Load()
    {
        muted = PlayerPrefs.GetInt("muted") == 1;
    }
    private void Save()
    {
        PlayerPrefs.SetInt("muted", muted ? 1 : 0);
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    isMuted = PlayerPrefs.GetInt("Muted") == 1;
    //    AudioListener.pause = isMuted;
    //}

    //// Update is called once per frame
    //public void MutePressed()
    //{
    //    isMuted = !isMuted;
    //    AudioListener.pause = isMuted;
    //    PlayerPrefs.SetInt("Muted", isMuted ? 1 : 0);

    //}
}
