using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerPart : MonoBehaviour
{
    private GameSystem gs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gs_obj = GameObject.FindGameObjectWithTag("GameSystem");
        gs = gs_obj.GetComponent<GameSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 30f * Time.deltaTime, 0f, Space.Self);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Capsule")
        {
            if (gameObject.name == "petal"){
                gs.foundPetals = true;
            }
            else if (gameObject.name == "pistil") {
                gs.foundPistil = true;
            }
            else if (gameObject.name == "stamen") {
                gs.foundStamen = true;
            }
            else if (gameObject.name == "ovules") {
                gs.foundOvules = true;
            }
            else if (gameObject.name == "sepals") {
                gs.foundSepals = true;
            }
            Destroy(gameObject);
            gs.source.PlayOneShot(gs.flowerPartObtained, 0.5f);
        }
    }
}
