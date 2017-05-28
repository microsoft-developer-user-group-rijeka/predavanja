using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class scrLevel : MonoBehaviour {
	
	public Text txtLevel;

	void Awake () {

		//SceneName = SceneName + 1;
		int SceneName=SceneManager.GetActiveScene().buildIndex;

		Debug.Log ("Scena je " + SceneName);
		txtLevel.text = ("Level: "+SceneName);
	}
	

}
