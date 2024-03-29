using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 100f;

    private void Update()
    {
        this.transform.Rotate(0f, 0f, rotateSpeed * Time.deltaTime);
    }

}
