using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetQuill : MonoBehaviour {


    public QuillPosition[] quills;
    [System.Serializable]
    public class QuillPosition
    {
        public Transform _localPosition;
        public Vector3 _positionStart;
        public Quaternion _rotationStart;

        internal void RecordPosition()
        {
            _positionStart = _localPosition.localPosition;
            _rotationStart = _localPosition.localRotation;
        }

        internal void ResetPosition()
        {
           _localPosition.localPosition = _positionStart;
            _localPosition.localRotation= _rotationStart;
        }
    }
	// Use this for initialization
	void Awake () {
        foreach (QuillPosition quill in quills)
        {
            quill.RecordPosition();
        }

    }
	
	// Update is called once per frame
	public void ResetPositions () {
        foreach (QuillPosition quill in quills)
        {
            quill.ResetPosition();
        }

    }
}
