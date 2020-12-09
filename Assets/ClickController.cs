using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour {

    public ClickData clickData;
    
    public void click() {
        clickData.incCounter();
    }
}
