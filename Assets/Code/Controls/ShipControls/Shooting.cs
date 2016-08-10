using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooting : MonoBehaviour {
    private WeaponSystem weaponSystem;
	// Use this for initialization
	void Start () {
	        weaponSystem = transform.GetComponentInChildren<WeaponSystem>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (InputMapping.Fire1()) {
            weaponSystem.Shoot();
	    }
	}
}