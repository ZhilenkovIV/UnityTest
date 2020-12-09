using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerController : MonoBehaviour {

    // Use this for initialization

    public Spauner spawner;

    public InputField periodField;
    public InputField distanceField;
    public InputField speedField;

    public void Start() {
        periodField.text = spawner.period.ToString();
        distanceField.text = spawner.lifeDistance.ToString();
        speedField.text = spawner.speedCube.x.ToString();
        periodField.onValueChanged.AddListener((n)=> float.TryParse(n, out spawner.period));
        distanceField.onValueChanged.AddListener((n) => float.TryParse(n, out spawner.lifeDistance));
        speedField.onValueChanged.AddListener((n) => float.TryParse(n, out spawner.speedCube.x));
    }

    

}
