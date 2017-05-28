using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class txtGameOver : MonoBehaviour {
  //  private txtGameOver GameOver;
    public Text GO;
    public Text P1;
    public Text P2;
    public void GameOverText()
    {
        
        GO.enabled = true;
        Player pc = new Player();
        P1.text="Player 1: "+pc.PlayerScore1(1, 1).ToString();
        P2.text="Player 2: "+pc.PlayerScore2(2, 1).ToString();
        
    }

    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   

}
