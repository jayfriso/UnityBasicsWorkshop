using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockController : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float horizontalValue = Input.GetAxis("Horizontal"); //Will give you an input value from -1 to 1
        transform.Translate(new Vector3(horizontalValue * speed * Time.deltaTime, 0, 0));
	}
}
