using UnityEngine;
using System.Collections;

public class Laser : Bullet {


    private float speed = 120;
    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update() {
        float speedTimeDelta = speed*Time.deltaTime;
        transform.Translate(0, 0, speedTimeDelta);
    }
}
