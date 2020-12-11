using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickController : MonoBehaviour {

    public ClickData clickData;

    public void Start()
    {
        GetComponent<Button>().onClick.AddListener(() => clickData.ClickCounter++);
    }

}
