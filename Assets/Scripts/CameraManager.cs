using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {

    [SerializeField] GameObject cameraPlayerA;
    [SerializeField] GameObject cameraPlayerB;
    [SerializeField] GameObject cameraBothPlayers;

    [SerializeField] private KeyCode keySwitch;

    private int current = 0;
    private bool unpressedLastFrame = true;

    private void Start() {
        UpdateCameras();
    }

    private void Update() {
        var pressed = Input.GetKey(keySwitch);

        if(pressed && unpressedLastFrame) {
            current++;
            if(current > 2) current = 0;

            UpdateCameras();
        }
        unpressedLastFrame = !pressed;
    }

    private void UpdateCameras() {
        Debug.Log(current);
        cameraPlayerA.SetActive(current == 0);
        cameraPlayerB.SetActive(current == 1);
        cameraBothPlayers.SetActive(current == 2);
    }

}
