using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
         if (player == null)
        {
            Debug.LogError("Internal error: could not find the Player object - did you remove its 'Player' tag?");
            return;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        // Vector3 normDir = (player.position - npc.position).normalized;

        // normDir = Quaternion.AngleAxis(Random.Range(0, 89), Vector3.up) * normDir;

        // Vector3 move = transform.position - (normDir * 10f);
        // player.SetDestination(move);
        // player.isStopped = false;
        
    }
}
