using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {


    void OnCollisionEnter(Collision target)
    {
        if (target.gameObject.tag == "color")
        {
            base.gameObject.GetComponent<Collider>().enabled = false;
            target.gameObject.GetComponent<MeshRenderer>().enabled = true;
            target.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
            base.GetComponent<Rigidbody>().AddForce(Vector3.down * 50, ForceMode.Impulse);
            HeartsFun(target.gameObject);
            Destroy(base.gameObject, .5f);
            print("Game Over");
        }
        else
        {
            GameObject.Find("hitSound").GetComponent<AudioSource>().Play();
            base.gameObject.GetComponent<Collider>().enabled = false;
            GameObject gameObject = Instantiate(Resources.Load("splash1")) as GameObject;
            gameObject.transform.parent = target.gameObject.transform;
            Destroy(gameObject, 0.1f);
            target.gameObject.name = "color";
            target.gameObject.tag = "color";
            StartCoroutine(ChangeColor(target.gameObject));
        }
    }

    IEnumerator ChangeColor(GameObject g)
    {
        yield return new WaitForSeconds(0.1f);
        g.gameObject.GetComponent<MeshRenderer>().enabled = true;
        g.gameObject.GetComponent<MeshRenderer>().material.color = BallHandler.oneColor;
        Destroy(base.gameObject);
    }

    void HeartsFun(GameObject g)
    {
        int @int = PlayerPrefs.GetInt("hearts");
        if(@int == 1)
        {
            FindObjectOfType<BallHandler>().FailGame();
            FindObjectOfType<BallHandler>().HeartsLow();
        }
    }

}
