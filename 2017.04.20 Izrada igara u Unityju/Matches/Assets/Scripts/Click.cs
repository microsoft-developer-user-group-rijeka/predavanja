using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour {
    public Button btn;
    public GameObject[] Pre;
    public Text P1;
    public Text P2;
    // Use this for initialization
    void Start () {
        Button b = btn.GetComponent<Button>();
        b.onClick.AddListener(NextPlayer);
      
    }

    private void NextPlayer()
    {
        Pre = GameObject.FindGameObjectsWithTag("Destroy");
        int preostali;
        preostali = Pre.Length;
        Debug.Log("Destroy ima :" + preostali);
        for (int i=0; i<preostali; i++)
        {
            Pre[i].tag = "Match";
        }
        GlobaVariables.Control = false;
       if (PlayerIndefikator.PlayID==1) {

            P2.color = Color.red;
            P1.color = Color.black;
            PlayerIndefikator.PlayID = 2;
        }
       else if (PlayerIndefikator.PlayID==2)
        {
            P1.color = Color.red;
            P2.color = Color.black;
            PlayerIndefikator.PlayID = 1;
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
