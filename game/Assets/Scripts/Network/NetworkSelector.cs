using UnityEngine;
using MLAPI;

public class NetworkSelector : MonoBehaviour
{
    [SerializeField] string nullString = "Null"; 
    void Awake()
    {
        if (SystemInfo.graphicsDeviceType.ToString().Equals(nullString))
        {
            NetworkingManager.Singleton.StartServer();
            Debug.Log("Server Started");
        }
        else 
        {
            NetworkingManager.Singleton.StartClient();
            Debug.Log("Client Started");
        }
    }
}
