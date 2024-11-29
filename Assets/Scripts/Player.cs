
using UnityEngine;
using TMPro;

public enum PlayerType {Null, Spymaster, Operative }



public class Player : Singleton<Player> 
{


    public string playerName;
    public Team team;
    public PlayerType playerType;
    public TextMeshProUGUI playerNameText;

    
    
    
}
