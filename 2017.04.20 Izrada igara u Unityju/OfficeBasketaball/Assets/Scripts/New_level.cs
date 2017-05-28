using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class New_level : MonoBehaviour {
	
	public Text txtLevel;


	void Start(){
		
	//txtLevel.text = ("Level: " + SceneName);
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		int SceneName=SceneManager.GetActiveScene().buildIndex;

		if (other.gameObject.tag == "Player"){
				SceneName = SceneName + 1;
				SceneManager.LoadScene (SceneName);
	//			txtLevel.text = ("Level: " + SceneName);	   
		}


	}


}