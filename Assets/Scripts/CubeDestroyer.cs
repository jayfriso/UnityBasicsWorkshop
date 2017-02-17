using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroyer : MonoBehaviour {

    void OnTriggerEnter(Collider other) {
        if (other.tag == "SpinningCube") {
            Destroy(other.gameObject);
        }
    }
}
