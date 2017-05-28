using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class LoadMatches : MonoBehaviour {
    public GameObject match;
    
  
    GameObject[] matchArray = new GameObject[15];

    void Start () {
       
        DrawMatches();
     }
    private void DrawMatches()
    {
      
  
        int y = 4;
        int x = -4;
        int n = 0;
        
            for (int i = -4; i < 5; i += 2)
            {

                for (int j = x; j < y + 1; j += 2)
                {
               
                 matchArray[n]=Instantiate(match, new Vector3(j, i, 0), Quaternion.identity) as GameObject;
                 matchArray[n].name= Convert.ToString(n);
         
                 n++;
                 
                }
                y = y - 1;
                x = x + 1;
            }
        
    }

   
}
