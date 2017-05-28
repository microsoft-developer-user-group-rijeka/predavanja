using UnityEngine;
using System.Collections;

public class DragDrop : MonoBehaviour {

	float x;
	float y;

	// Update is called once per frame
	void Update(){
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}
	void OnMouseDrag(){
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10.0f));
	}
}
