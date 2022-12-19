using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;
    private bool idle;
    public AudioSource bugsource;
    public AudioClip bugCrawl;

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

    bool IsHazard()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 100f))
        {
            if (hit.transform.tag == "hazard")
            {
                return true;
            }
        }
        return false;

    }

    // Update is called once per frame
    void Update()
    {
        if (IsHazard())
        {
            hp--;
        }
        if (hp < 1)
        {
            
            Destroy(gameObject, .5f);
        }
    }
}
