using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public Text time_text;
    public Image end;

    public Text inventory_text;
    public Text petals;
    public Text pistil;
    public Text stamen;
    public Text ovules;
    public Text sepals;

    private int items_left;
    private int time_remaining;

    internal bool foundPetals = false;
    internal bool foundPistil = false;
    internal bool foundStamen = false;
    internal bool foundOvules = false;
    internal bool foundSepals = false;

    // Start is called before the first frame update
    void Start()
    {
        time_text.text = "05:00";
        time_remaining = 300;

        PlayerPrefs.SetInt("foundOvules", 0);
        PlayerPrefs.SetInt("foundSepals", 0);

        items_left = 5;
        end.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // INVENTORY LOGIC
        inventory_text.text = items_left + " Parts Left to Find:";

        if (foundPetals) {
            items_left -= 1;
            petals.text = "Petals";
            foundPetals = false;
        }

        if (foundPistil) {
            items_left -= 1;
            pistil.text = "Pistil";
            foundPistil = false;
        }

        if (foundStamen) {
            items_left -= 1;
            stamen.text = "Stamen";
            foundStamen = false;
        }

        if (foundOvules) {
            items_left -= 1;
            ovules.text = "Ovules";
            foundOvules = false;
        }

        if (foundSepals) {
            items_left -= 1;
            sepals.text = "Sepals";
            foundSepals = false;
        }

        if (items_left == 0) {
            // do something, like switch to win screen
        }
        

        // TIMER LOGIC
        if (!pauseMenu.paused)
        {
            time_remaining = 300 - ((int)Time.timeSinceLevelLoad);
        }

        if (time_remaining < 0) {
            // do something, like switch to lose screen
            time_remaining = 0;
            pauseMenu.paused = true;
            end.enabled = true;
        }

        int minutes = (int) Mathf.Floor(time_remaining / 60);
        int seconds = time_remaining - (minutes * 60);

        if (seconds < 10) {
            time_text.text = "0" + minutes + ":0" + seconds;
        } else {
            time_text.text = "0" + minutes + ":" + seconds;
        }

    }
}
