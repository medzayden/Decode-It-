
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;

public enum Team {Null, Red, Blue }

public class TeamManager : MonoBehaviour
{
    public List<Player> redTeam = new List<Player>();
    public List<Player> blueTeam = new List<Player>();




    public void JoinTeam()
    {
        Player.instance.team = Team.Red;
        Debug.Log("joined!!!!!! red" );
        redTeam.Add( Player.instance);
    }
    public void JoinBlue()
    {

        Player.instance.team = Team.Blue;
        Debug.Log("joined!!!!!! Blue");
        blueTeam.Add(Player.instance);
       
    }
    public void GetRoleOperative()
    {
        Player.instance.playerType = PlayerType.Operative;
        Debug.Log("joined!!!!!! Operative");
    }
    public void GetRoleSpyMaster()
    {
        Player.instance.playerType = PlayerType.Spymaster;
        Debug.Log("joined!!!!!! Spymaster");
    }

}
