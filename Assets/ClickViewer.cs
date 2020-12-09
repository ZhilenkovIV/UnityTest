using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickViewer : MonoBehaviour {

    public ClickData clickData;
    private Text text;

    void Start () {
        text = GetComponent<Text>();
        clickData.notify += (counter) => text.text = "Число кликов = " + counter;
    }
	
}
