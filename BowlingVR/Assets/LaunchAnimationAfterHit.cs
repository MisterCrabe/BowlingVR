using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchAnimationAfterHit : MonoBehaviour {

    public PlayMakerFSM stateMachine;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        stateMachine.SetState("Active");
    }
}
