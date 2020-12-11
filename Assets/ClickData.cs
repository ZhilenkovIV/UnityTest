using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickData : MonoBehaviour {
    public delegate void ClickNotify(int counter);
    public event ClickNotify notify;

    [SerializeField]
    private int clickCounter = 0;

    public int ClickCounter {
        get {
            return clickCounter;
        }

        set {
            clickCounter = value;
            if (notify != null)
            {
                notify(clickCounter);
            }
        }
    }
    
    
    
}
