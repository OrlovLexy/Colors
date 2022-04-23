using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFloat : MonoBehaviour {
    public float speed, tilt;
    public Vector3 targetUp;
    public Vector3 targetDown;
    private Vector3 target;
    // Update is called once per frame
	void Update () {
        if (transform.position == target || target != targetUp & target != targetDown)
        {
            if (target == targetUp) target = targetDown;
            else target = targetUp;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        transform.Rotate(Vector3.down * Time.deltaTime * tilt);
    }
}
