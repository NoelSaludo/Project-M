using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public Vector3 cameraOffset = Vector3.zero;
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void LateUpdate()
    {
        transform.position = player.transform.position + cameraOffset;
    }
}
