using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooting : MonoBehaviour {
    [SerializeField] private GameObject[] parentWeapons;
    private List<Weapon> weapons = new List<Weapon>();
	// Use this for initialization
	void Start () {
	    foreach (GameObject parentWeapon in parentWeapons) {
	        weapons.Add(parentWeapon.transform.GetChild(0).gameObject.GetComponent<Weapon>());
	    }
	}
	
	// Update is called once per frame
	void Update () {
	    if (InputMapping.Fire1()) {
	        foreach (Weapon weapon in weapons) {
	            weapon.Shoot();
	        }
	    }
	}
}