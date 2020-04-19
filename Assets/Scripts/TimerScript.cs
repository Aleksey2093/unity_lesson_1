using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {
    public UnityEngine.UI.Text textOfTimer;
    public UnityEngine.UI.Text textOfButton;
    public UnityEngine.UI.Button button;

    // Start is called before the first frame update
    void Start() {
        button.onClick.AddListener(ButtonClick);
    }

    public bool timerStatus = false;
    public float timerSecOld;

    public void ButtonClick() {
        timerStatus = !timerStatus;
        timerSecOld = Time.time;
        textOfButton.text = timerStatus ? "Остановить" : "Запустить";
    }

    // Update is called once per frame
    void Update() {
        if (!timerStatus) return;
        float sec = Time.time - timerSecOld;
        textOfTimer.text = $"{sec:f1} c.";
    }
}




