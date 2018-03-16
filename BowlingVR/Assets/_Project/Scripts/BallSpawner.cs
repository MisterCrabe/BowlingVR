using Assets._Project.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallSpawner : MonoBehaviour {

    public Transform spawnPoint;
    public GameObject objectToSpawn;
    public KeyCode touchToSpawn = KeyCode.Space;

    [Header("Debug dont't Touch")]
    public GameObject lastCreatedObject;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SpawnObject();
        }
    }

    protected virtual void SpawnObject()
    {
        Rigidbody rigidbodyObject = objectToSpawn.GetComponent<Rigidbody>();
        if (rigidbodyObject != null)
        {
            rigidbodyObject.isKinematic = true;
        }
        lastCreatedObject = GameObject.Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation).gameObject;
    }




}
