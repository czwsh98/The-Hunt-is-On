using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class player : NetworkBehaviour {

    public static player hunter;
    public bool isHunter;

	// Use this for initialization
	void Start () {
        if (!isLocalPlayer)
            Destroy(gameObject);
	}

    public override void OnStartClient()
    {
        if (hunter == null)
        {
            hunter = this;
            isHunter = true;
        }
        else
            isHunter = false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
