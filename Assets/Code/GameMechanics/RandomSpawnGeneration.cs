using UnityEngine;
using System.Collections;

public class RandomSpawnGeneration : MonoBehaviour {
    [SerializeField] private float maxVertRadius = 10f;
    [SerializeField] private float maxHorzRadius = 20f;
    [SerializeField] private float interval = 0.05f;
    [SerializeField] private Transform child;
    private float nextFire ;

    void Start() {
        nextFire = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
	    if (Time.time > nextFire) {
	        nextFire = Time.time + interval;
            float vert = Random.Range(-maxVertRadius,maxVertRadius);
	        float horz = Random.Range(-maxHorzRadius, maxHorzRadius);
	        Instantiate(child, new Vector3(horz, vert, transform.position.z), transform.rotation);
	    }
	}
}
