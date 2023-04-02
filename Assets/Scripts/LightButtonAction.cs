using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightButtonAction : MonoBehaviour
{
    public GameObject obj;
    private bool isOn;

    void Start() {
        isOn = true;
    }

    public void toggleVisible() {
        isOn = !isOn;
        obj.SetActive(isOn);
    }
}
