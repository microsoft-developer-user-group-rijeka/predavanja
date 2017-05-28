using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour {
    float x;
    float y;
    public GameObject match;
    public Camera mainCamera;
   
    private GameObject lastSelected = null; // store last selected object reference
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { // if LMB clicked
            bool cubeHit = false;
            RaycastHit raycastHit = new RaycastHit(); // create new raycast hit info object
            if (Physics.Raycast(mainCamera.ScreenPointToRay(Input.mousePosition), out raycastHit))
            { // create ray from screen's mouse position to world and store info in raycastHit object
                if (raycastHit.collider.tag == "Match")
                    Debug.Log("Nešto sam pogodio");
                { // we just want to hit objects tagged with "Cube"
                    cubeHit = true; // yup, we hit it!
                }
            }

            Deselect(lastSelected); // deselect last hit object
            if (cubeHit)
                Select(raycastHit.collider.gameObject); // select new cube
        }
    }
    private void Select(GameObject g)
    {
      
    }

    private void Deselect(GameObject g)
    {
       
    }
}
