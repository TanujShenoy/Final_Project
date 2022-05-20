using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ObjectClicker : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera cam1;
    [SerializeField] CinemachineVirtualCamera cam2;
    [SerializeField] CinemachineVirtualCamera cam3;
    [SerializeField] CinemachineVirtualCamera cam4;
    [SerializeField] CinemachineVirtualCamera cam5;
    [SerializeField] CinemachineVirtualCamera cam6;
    [SerializeField] CinemachineVirtualCamera cam7;
    [SerializeField] CinemachineVirtualCamera cam8;
    [SerializeField] CinemachineVirtualCamera cam9;

    private void OnEnable()
    {
        CameraSwitcher.Register(cam1);
        CameraSwitcher.Register(cam2);
        CameraSwitcher.Register(cam3);
        CameraSwitcher.Register(cam4);
        CameraSwitcher.Register(cam5);
        CameraSwitcher.Register(cam6);
        CameraSwitcher.Register(cam7);
        CameraSwitcher.Register(cam8);
        CameraSwitcher.Register(cam9);
        CameraSwitcher.SwitchCamera(cam1);
    }

         private void OnDisable()
             {
                CameraSwitcher.Unregister(cam1);
                CameraSwitcher.Unregister(cam2);
                CameraSwitcher.Unregister(cam3);
                CameraSwitcher.Unregister(cam4);
                CameraSwitcher.Unregister(cam5);
                CameraSwitcher.Unregister(cam6);
                CameraSwitcher.Unregister(cam7);
                CameraSwitcher.Unregister(cam8);
                CameraSwitcher.Unregister(cam9);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            CameraSwitcher.SwitchCamera(cam2);
        }

        if (Input.GetKeyDown("2"))
        {
            CameraSwitcher.SwitchCamera(cam3);
        }

        if (Input.GetKeyDown("3"))
        {
            CameraSwitcher.SwitchCamera(cam4);
        }

        if (Input.GetKeyDown("4"))
        {
            CameraSwitcher.SwitchCamera(cam5);
        }

        if (Input.GetKeyDown("5"))
        {
            CameraSwitcher.SwitchCamera(cam6);
        }

        if (Input.GetKeyDown("6"))
        {
            CameraSwitcher.SwitchCamera(cam7);
        }

        if (Input.GetKeyDown("7"))
        {
            CameraSwitcher.SwitchCamera(cam8);
        }

        if (Input.GetKeyDown("backspace"))
        {
            CameraSwitcher.SwitchCamera(cam1);
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.transform != null)
                {
                    Rigidbody rb;

                    if (rb = hit.transform.GetComponent<Rigidbody>())
                    {
                        PrintName(hit.transform.gameObject);
                        CameraSwitcher.SwitchCamera(cam9);
                    }
                }
            }
        }


    }

    void PrintName(GameObject go)
    {
        print(go.name);
    }
}