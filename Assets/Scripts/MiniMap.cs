using UnityEngine;

public class MiniMap : MonoBehaviour
{
    [SerializeField]
    private Transform camera;
    public Transform indicator;
    void LateUpdate() {
        Vector3 newPosition = indicator.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        transform.rotation = Quaternion.Euler(90f, camera.rotation.eulerAngles.y, 0f);
    }
}
