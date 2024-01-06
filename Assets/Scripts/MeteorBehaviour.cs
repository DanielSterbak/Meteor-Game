using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorBehaviour : MonoBehaviour {
    public float maxLifeTime = 3f;

    void Start()
    {
        Destroy(gameObject, maxLifeTime);
    }
}