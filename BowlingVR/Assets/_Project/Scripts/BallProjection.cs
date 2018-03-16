using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets._Project.Scripts
{
    public class BallProjection : MonoBehaviour
    {
        public LineRenderer lineRenderer;
        public BallSpawnerWithPropulsion ballSpawner;
        public BallSpawner originPosition;
        public int step;

        void Start()
        {
            lineRenderer.positionCount = step;
        }

        void Update()
        {
            UpdateLineRenderer();
        }


        // TODO modifier en lineRenderer.SetPositions -> Vector3[]
        public void UpdateLineRenderer()
        {
            float time = 0;
            for (int i = 1; i < step; i++)
            {
                lineRenderer.SetPosition(i, Projection(originPosition.spawnPoint.position, ballSpawner.velocity, Physics.gravity, time));
                time += 0.2f;
            }
        }

        public Vector3 Projection(Vector3 origin, Vector3 velocity, Vector3 gravity, float time)
        {
            Vector3 projection = origin + (velocity * time) + ((Physics.gravity * (time * time)) * 0.5f );
            return projection;
        }

    }
}
