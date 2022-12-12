using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public void Switch(int sceneID) {
        SceneManager.LoadScene(sceneID);
    }
}

//code is written by our group (Lo Hazarika)