using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowFieldParticule : MonoBehaviour
{
    public float _moveSpeed;

    private void Start()
    {
        //GetComponentInChildren<MeshRenderer>().material.color = Random.ColorHSV(0.1f, 0.7f, 0.5f, 1f, 1f, 1f);
        //GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0.1f, 0.5f), Random.Range(0.5f, 1f), 1.0f);
        //GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(1f, 1f), Random.Range(0f, 0.6f), Random.Range(0f, 0f), 1.0f);
        //GetComponentInChildren<MeshRenderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0.1f, 0.5f), Random.Range(0.5f, 1f), 1.0f);
    }

    void Update()
    {
        transform.position -= transform.right * _moveSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y - 180, transform.rotation.z);
    }

    public void ApplyRotation(Vector3 rotation, float rotateSpeed)
    {
        Quaternion targetRotation = Quaternion.LookRotation(rotation.normalized);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotateSpeed *Time.deltaTime);
    }
}
