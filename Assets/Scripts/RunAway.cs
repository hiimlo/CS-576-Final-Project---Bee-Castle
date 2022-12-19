using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAway : MonoBehaviour
{
    public GameObject player;
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 normDir = (player.transform.position - transform.position).normalized;
        float dist = (player.transform.position - transform.position).magnitude;

        if (dist < 50) { //num is to see if player is inside of chasing range
            speed = 0.5f;
            transform.LookAt(new Vector3(player.transform.position.x, 0, player.transform.position.z));
            transform.position -= normDir * speed * Time.deltaTime;
        }
        else if (dist < 20) {
            speed = 2.0f;
            transform.LookAt(new Vector3(player.transform.position.x, 0, player.transform.position.z));
            transform.position -= normDir * speed * Time.deltaTime;
        }      
    }
}
