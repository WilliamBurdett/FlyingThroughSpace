﻿using UnityEngine;

    public virtual Bullet bullet { get; protected set; }
    public virtual Vector3[] baseDirections { get; protected set; }


    // Use this for initialization

    protected virtual void Start() {

    protected virtual void InstantiateBullets() {
        foreach(Vector3 direction in baseDirections) {
    }

    // Update is called once per frame
    void Update() {}
