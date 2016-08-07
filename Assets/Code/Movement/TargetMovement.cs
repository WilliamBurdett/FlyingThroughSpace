using UnityEngine;
using System.Collections;

public class TargetMovement : MonoBehaviour {
    [SerializeField] private float speed = 5;

    public float Speed {
        get { return speed; }
        set { speed = value; }
    }


    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update() {
        float timeDeltaSpeed = speed * Time.deltaTime;
        if (InputMapping.Up() > 0) {
            transform.Translate(0,timeDeltaSpeed,0);
        }
        if(InputMapping.Right() > 0) {
            transform.Translate(timeDeltaSpeed,0,0);
        }
        if(InputMapping.Left() > 0) {
            transform.Translate(-timeDeltaSpeed,0,0);
        }
        if(InputMapping.Down() > 0) {
            transform.Translate(0,-timeDeltaSpeed,0);
        }
    }
}
