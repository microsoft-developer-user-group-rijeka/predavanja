using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    public static int PlayerID;
    public static int PlayerScore;


    public  int PlayerScore1(int IDPlayer, int ScrPlayer)
    {
        PlayerID = IDPlayer;
        PlayerScore = PlayerScore + ScrPlayer;
        return PlayerScore;

    }

    public int PlayerScore2(int IDPlayer, int ScrPlayer)
    {
        PlayerID = IDPlayer;
        PlayerScore = PlayerScore + ScrPlayer;
        return PlayerScore;
    }

}
public static class GlobaVariables
{
    public static bool Control=false;
}
public static class PlayerIndefikator
{
    public static int PlayID=1;
}
public class PlayerClass : MonoBehaviour {
    
   
   
}
