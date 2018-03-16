using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets._Project.Scripts
{
    public class BallSpawnerWithPropulsion : MonoBehaviour
    {

        [Header("Position Params")]
        public Transform spawnPoint;
        public GameObject objectToSpawn;
        public KeyCode touchToSpawn = KeyCode.Space;

        [Header("Propulsion Params")]
        public Transform forceDirection;
        public float forceIntensity = 10f;

        [Header("Debug dont't Touch")]
        public GameObject lastCreatedObject;
        public Vector3 velocity;

        void Update()
        {
            if (Input.GetMouseButton(0) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
            {
                
                forceIntensity += 0.5f;
            }

            if (Input.GetMouseButtonUp(0) || OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger))
            {

                SpawnObject();
                velocity = forceDirection.forward * forceIntensity;
                Rigidbody rigidbodyObject = lastCreatedObject.GetComponent<Rigidbody>();
                if (rigidbodyObject != null)
                {
                    rigidbodyObject.isKinematic = false;
                    rigidbodyObject.AddForce(velocity, ForceMode.Impulse);
                    Debug.Log("Pourcent : " + forceIntensity);
                }
                forceIntensity = 10f;
            }

            else
            {
                Debug.LogWarning("RigidBody not found", this);
            }
        }

        void SpawnObject()
        {
            Rigidbody rigidbodyObject = objectToSpawn.GetComponent<Rigidbody>();
            if (rigidbodyObject != null)
            {
                rigidbodyObject.isKinematic = true;
            }
            lastCreatedObject = GameObject.Instantiate(objectToSpawn, spawnPoint.position, spawnPoint.rotation).gameObject;
        }
    }
}
