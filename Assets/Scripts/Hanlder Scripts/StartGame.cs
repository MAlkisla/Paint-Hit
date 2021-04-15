using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {

    public Text levelNo;
    public Text TargetText;
    
	void OnEnable () {
        levelNo.text = LevelsHandlerScript.currentLevel + string.Empty;
        TargetText.text = LevelsHandlerScript.totalCircles + string.Empty;
        StartCoroutine(DelayedRemoval());
	}
	
	IEnumerator DelayedRemoval()
    {
        yield return new WaitForSeconds(1);
        base.gameObject.SetActive(false);
    }
}
