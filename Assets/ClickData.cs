using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickData : MonoBehaviour {
    public delegate void ClickNotify(int counter);
    public event ClickNotify notify;

    [SerializeField]
    private int clickCounter = 0;
    
    public void incCounter() {
        clickCounter++;
        if (notify != null)
        {
            notify(clickCounter);
        }
    }
    
    
}
