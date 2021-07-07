using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lobby_Peter_Tan : MonoBehaviour {

    public bool OfflineMode;
    public bool ConnectedToMaster;
    public bool JoinedLobby;
    public IEnumerator WaitForConnectionCoroutine;
    public enum ConnectionType { SinglePlayer, MultiPlayer };
    public ConnectionType connectionType;


    [SerializeField]
    private Text _ConnectionStatus;
    public Text ConnectionStatus { get { return _ConnectionStatus; } }

    private void Awake()
    {
    }
    // Use this for initialization
    private void Start()
    {
    }

    private void OnConnectedToMaster()
    {
    }

    private void OnJoinedLobby()
    {
    }
}
