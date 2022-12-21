using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FlowerPart : MonoBehaviour
{
    private GameSystem gs;

    public EnableDisableGetPart ui_switch;
    public GameObject image;
    public Sprite flower_part;
    public TMP_Text found_flower_part;
    public TMP_Text part_description;

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
                found_flower_part.text = "You found the petals!";
                image.GetComponent<Image>().sprite = flower_part;
                part_description.text = "Petals are modified leaves that surround the reproductive parts of flowers. They are often brightly colored or unusually shaped to attract pollinators.";
                ui_switch.EnableCanvas();
                gs.foundPetals = true;
            }
            else if (gameObject.name == "pistil") {
                found_flower_part.text = "You found the pistil!";
                image.GetComponent<Image>().sprite = flower_part;
                part_description.text = "The pistil is a discrete organ in the center of a flower capable of receiving pollen and producing a fruit.";
                ui_switch.EnableCanvas();
                gs.foundPistil = true;
            }
            else if (gameObject.name == "stamen") {
                found_flower_part.text = "You found the stamen!";
                image.GetComponent<Image>().sprite = flower_part;
                part_description.text = "The stamen is a male reproductive organ of a flower. It produces the pollen. The stamen has two parts: anther and stalk. The stalk is also called a filament.";
                ui_switch.EnableCanvas();
                gs.foundStamen = true;
            }
            else if (gameObject.name == "ovules") {
                found_flower_part.text = "You found the ovules!";
                image.GetComponent<Image>().sprite = flower_part;
                part_description.text = "Ovules produce the female reproductive cells which get fertilized during sexual reproduction in seed plants. The word literally means 'small egg.'";
                ui_switch.EnableCanvas();
                gs.foundOvules = true;
            }
            else if (gameObject.name == "sepals") {
                found_flower_part.text = "You found the sepals!";
                image.GetComponent<Image>().sprite = flower_part;
                part_description.text = "Sepals are one of the basic parts of a flower. They are found below the petals. The sepals are often small and green.";
                ui_switch.EnableCanvas();
                gs.foundSepals = true;
            }
            Destroy(gameObject);
            gs.source.PlayOneShot(gs.flowerPartObtained, 0.5f);
        }
    }
}
