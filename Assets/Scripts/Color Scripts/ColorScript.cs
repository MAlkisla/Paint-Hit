using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour {

    public Color[] color1;
    public Color[] color2;
    public Color[] color3;

    public static Color[] colorArray;

    void OnEnable ()
    {
        ChangeColor();
	}

    public void ChangeColor()
    {
        int randomC = Random.Range(0, 2);

        PlayerPrefs.SetInt("ColorSelect", randomC);
        PlayerPrefs.GetInt("ColorSelect");

        if (PlayerPrefs.GetInt("ColorSelect") == 0)
            colorArray = color1;

        if (PlayerPrefs.GetInt("ColorSelect") == 1)
            colorArray = color2;

        if (PlayerPrefs.GetInt("ColorSelect") == 2)
            colorArray = color3;
    }

    private static ColorScript instance;
    public static ColorScript Instance
    {
        get { return instance; }
    }



    private void Awake()
    {
        if (instance != null && instance != this)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


}
