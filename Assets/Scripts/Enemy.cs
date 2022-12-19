using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;
    private bool idle;

    private float radius_of_search_for_player;
    private GameObject fps_player_obj;
    public AudioClip attacksfx;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        idle = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
