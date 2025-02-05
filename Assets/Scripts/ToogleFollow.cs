using Unity.Cinemachine;
using UnityEngine;

public class ToogleFollow : MonoBehaviour
{
    public CinemachineCamera virtualCamera;

    public GameObject player1, player2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            virtualCamera.Follow = player1.transform;
        }
        if (Input.GetKey(KeyCode.E))
        {
            virtualCamera.Follow = player2.transform;
        }
    }
}
