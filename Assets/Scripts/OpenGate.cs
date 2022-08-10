using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour {
    [SerializeField] KeyCode openKey = KeyCode.E;
    [SerializeField] Transform openPos;
    [SerializeField] float openSpeed = 10.0f;

    private Vector3 target;
    private float reachedDist;
    bool openNow;

    private void Start() {
        target = openPos.position;
        reachedDist = 0.1f * 0.1f;
    }

    private void Update() {
        if(Input.GetKeyDown(openKey))
            openNow = true;
        if(openNow) {
            Debug.Log("ENT");
            transform.position = Vector3.Lerp(transform.position, target, openSpeed * Time.deltaTime);
            if((transform.position - target).sqrMagnitude < reachedDist)
                Destroy(this);
        }
    }
}
