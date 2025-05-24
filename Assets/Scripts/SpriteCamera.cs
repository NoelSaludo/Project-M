using UnityEngine;

public class SpriteCamera : MonoBehaviour
{
    [SerializeField]
    public Camera camera;

    private void LateUpdate()
    {
        Vector3 cameraPos = camera.transform.position;
        
        cameraPos.y = camera.transform.position.y;
        
        transform.LookAt(cameraPos);
        transform.Rotate(new Vector3(0, 180, 0));
    }
}
