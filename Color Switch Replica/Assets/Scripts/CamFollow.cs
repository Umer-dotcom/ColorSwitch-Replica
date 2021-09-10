using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [Header("Target To Follow")]
    [SerializeField] private Transform target;

    private void Start()
    {
        GameObject targetTemp = GameObject.FindGameObjectWithTag("Player");
        if (targetTemp) //If target found
        {
            target = targetTemp.GetComponent<Transform>();
        }
    }

    private void Update()
    {
        if (target)
        {
            if (target.position.y > this.transform.position.y)
            {
                transform.position = new Vector3(transform.position.x, target.position.y, transform.position.z);
            }
        }
    }

}
