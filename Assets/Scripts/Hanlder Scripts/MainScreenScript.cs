using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainScreenScript : MonoBehaviour
{
    public Text levelNo;

    void Start()
    {
        levelNo.text = LevelsHandlerScript.currentLevel + string.Empty;
        //StartCoroutine(DelayedRemoval());
    }

    //IEnumerator DelayedRemoval()
    //{
    //    yield return new WaitForSeconds(1);
    //    base.gameObject.SetActive(false);
    //}
}
