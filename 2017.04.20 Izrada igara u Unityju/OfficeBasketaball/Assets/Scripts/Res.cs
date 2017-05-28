using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Res : MonoBehaviour {
	


    //* void OnMouseDown() {
    public void restartCurrentScene() { 
    Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
	}

}
