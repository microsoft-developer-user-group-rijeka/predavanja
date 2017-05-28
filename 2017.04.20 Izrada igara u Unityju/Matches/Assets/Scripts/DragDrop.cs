using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using System.Collections.Generic;

public class DragDrop : MonoBehaviour {
   	float x;
	float y;
    public GameObject match;
    private txtGameOver txtGO;
     public GameObject[] GameObjectArray;

    private void Awake()
    {
        txtGO = GameObject.FindObjectOfType<txtGameOver>();
    }

    private void Start()
    {
      GameObjectArray = GameObject.FindGameObjectsWithTag("Match");
    }
     void Update(){
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
    }
void OnMouseDrag(){
	//	transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10.0f));
	}
    void OnMouseDown()
    {
        var boxes = GameObject.FindGameObjectsWithTag("Match");
       
        SelectMatches(match);
        if (boxes.Length == 1)
        {
            txtGO.GameOverText();
        }
    }
    void SelectMatches (GameObject m)
    {
       int n;
       n = Convert.ToInt32(m.name);
       if (n>=0 && n<=4)
        {
            if (GameObjectArray[n].CompareTag("Match") && GlobaVariables.Control==false)
            {
                ChangeTag(0, 4,n);
                
            }
            else if (GameObjectArray[n].CompareTag("Destroy") && GlobaVariables.Control == true)
            {
                GameObjectArray[n].SetActive(false);
            }

        }
      else if (n > 4 && n <= 8)
        {
            if (GameObjectArray[n].CompareTag("Match") && GlobaVariables.Control == false)
            {
                ChangeTag(5, 8, n);

            }
            else if (GameObjectArray[n].CompareTag("Destroy") && GlobaVariables.Control == true)
            {
                GameObjectArray[n].SetActive(false);
            }
        }
        else if (n > 8 && n <= 11)
        {
            if (GameObjectArray[n].CompareTag("Match") && GlobaVariables.Control == false)
            {
                ChangeTag(9, 11,n);

            }
            else if (GameObjectArray[n].CompareTag("Destroy") && GlobaVariables.Control == true)
            {
                GameObjectArray[n].SetActive(false);
            }
        }
        else if (n > 11 && n <= 13)
        {
            if (GameObjectArray[n].CompareTag("Match") && GlobaVariables.Control == false)
            {
                ChangeTag(12, 13, n);

            }
            else if (GameObjectArray[n].CompareTag("Destroy") && GlobaVariables.Control == true)
            {
                GameObjectArray[n].SetActive(false);
            }
        }
        else if (n==14)
        {
            if (GameObjectArray[n].CompareTag("Match") && GlobaVariables.Control == false)
            {
                ChangeTag(14, 14, n);

            }
            else if (GameObjectArray[n].CompareTag("Destroy") && GlobaVariables.Control == true)
            {
                GameObjectArray[n].SetActive(false);
            }
        }
   }
    void ChangeTag(int p, int z,int n)
    {
       
        for (int i = p; i <z+1; i++)
        {

          GameObjectArray[i].tag = "Destroy";
            Debug.Log(GameObjectArray[i].tag + " " + GameObjectArray[i]);
      

        }
      
        GameObjectArray[n].SetActive(false);
        GlobaVariables.Control = true;

    }
}


