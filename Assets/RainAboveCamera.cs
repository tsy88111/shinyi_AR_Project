using UnityEngine;

public class RainAboveCamera : MonoBehaviour
{
    public Camera arCamera;
    public float heightAboveCamera = 3f;

    void Start()
    {
        // Automatically find camera if not set
        if (arCamera == null)
        {
            arCamera = Camera.main;
        }
    }

    void Update()
    {
        // Rain follows camera position
        Vector3 rainPos = arCamera.transform.position;
        rainPos.y += heightAboveCamera;
        transform.position = rainPos;
    }
}