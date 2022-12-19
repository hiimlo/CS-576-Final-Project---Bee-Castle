using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;
    private bool idle;
    public AudioSource bugsource;
    public AudioClip bugCrawl;

    private float radius_of_search_for_player;
    private GameObject fps_player_obj;
    public AudioClip attacksfx;
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
        idle = true;
        bugsource.clip = bugCrawl;
        bugsource.loop = true;
        bugsource.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
