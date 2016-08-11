using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    public virtual float baseSpeed { get; protected set; }

    virtual protected void TargetMovement() {
        float speedTimeDelta = baseSpeed*Time.deltaTime;
        transform.Translate(0,0,speedTimeDelta);
    }


	// Update is called once per frame
	void Update () {
	    TargetMovement();
	}
}
