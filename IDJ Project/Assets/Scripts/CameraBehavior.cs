using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour {

    public Transform target;

    public Vector3 offset;

    private float CameraHeight;

    public float TranslateDelay;

	void LateUpdate()
    {
        offset = target.transform.position;
        var right = Input.GetKey("l");
        var left = Input. GetKey("j");
        transform.LookAt(target);
    }
}
