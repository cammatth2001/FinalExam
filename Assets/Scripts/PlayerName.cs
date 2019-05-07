using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
   
    static public string playerName;
    public Text Player;
    public void GetInput(string player)
    {
        playerName = player;
        Debug.Log(playerName);
    }

    public void Start()
    {
        Player.text = playerName;
    }

    public void Update()
    {
        Player.text = playerName;
    }

}
