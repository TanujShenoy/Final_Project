using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private GameObject[] MultipleCameras;
    public static Transform ClosestCamera;
    // Start is called before the first frame update
    void Start()
    {
        ClosestCamera = null;
    }

    // Update is called once per frame
    void Update()
    {
        ClosestCamera = getClosestCamera();
    }

    public Transform getClosestCamera()
    {
        MultipleCameras = GameObject.FindGameObjectsWithTag("Camera");
        float closestDistance = Mathf.Infinity;
        Transform trans = null;

        foreach (GameObject go in MultipleCameras)
        {
            float currentDistance = Vector3.Distance(transform.position, go.transform.position);
            closestDistance = currentDistance;
            trans = go.transform;
        }
        return trans;
    }
}
