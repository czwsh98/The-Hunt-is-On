using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class playerManager : NetworkBehaviour {

    public GameObject HunterPrefab;
    public GameObject BeastPrefab;

    private GameObject localPlayer;
    private GameObject hunter;
    private GameObject beast;

	// Use this for initialization
	void Start () {
		
	}

    public override void OnStartClient()
    {
        localPlayer = ClientScene.localPlayers[0].gameObject;

        if (localPlayer.GetComponent<player>().isHunter)
        {
            hunter = localPlayer;
            Instantiate(BeastPrefab);
        }
        else
            beast = localPlayer;
    }

    // Update is called once per frame
    void Update () {
        if (!isServer)
            return;

        if (hunter != null)
        {
            
        }
	}
}
