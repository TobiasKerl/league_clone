using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class p : MonoBehaviour
{

    NavMeshAgent agent;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Ray roy = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hot;
       
            if (Physics.Raycast(roy, out hot))
                agent.SetDestination(hot.point);
        }

    }

}
