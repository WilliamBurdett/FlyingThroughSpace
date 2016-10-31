using UnityEngine;
using System.Collections;

public class AutoDestroy : MonoBehaviour {
    [SerializeField] private float timeToLive = 10;
    private float spawnTime;
    // Use this for initialization
    void Start() {
        spawnTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        if (spawnTime + timeToLive < Time.time) {
            Destroy(gameObject);
        }
    }
}
