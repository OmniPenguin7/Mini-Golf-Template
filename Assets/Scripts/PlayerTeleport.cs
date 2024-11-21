using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    public GameObject player;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity);    
        }
    }

    public void TeleportPlayer()
    {
        player.transform.SetPositionAndRotation(target.transform.position, Quaternion.identity);
    }

}
