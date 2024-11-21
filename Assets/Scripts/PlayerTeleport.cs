using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public GameObject player; //sets a reference for the player

    public GameObject target; //sets a reference for the target object

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player"); //Find the player in the game to be used in code
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player")) //if there is a collision between the object i.e. gem, and the player
        {
            player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity); //Teleports the player to the selected target position i.e.cave
        }
    }

    public void TeleportPlayer() //Method for teleporting the player
    {
        player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity); //Teleports the player to the selected target position i.e. dungeon
    }

}
