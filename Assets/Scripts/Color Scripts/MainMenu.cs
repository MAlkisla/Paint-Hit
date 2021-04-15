using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Image BG;

    public Sprite[] spr;

    public GameObject pauseScreen;

	void Start () {
        BG.sprite = spr[Random.Range(0, 4)];
	}
	
	public void PauseGame()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
    }

    public void unPauseGame()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

}
