using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    public UIController ui;
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.GetComponent<Animator>())
        {
            print("Play");
            GetComponent<CapsuleCollider>().enabled = false;
            other.transform.parent.GetComponent<Animator>().enabled = true;
            StaticData.isWin = true;
            StaticData.saveExist = false;
            StartCoroutine(ActiveUI());
        }
    }

    IEnumerator ActiveUI()
    {
        yield return new WaitForSeconds(3f);
        ui._activeUI = true;
    }
}
