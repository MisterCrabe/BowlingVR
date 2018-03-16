using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using Assets._Project.Scripts;

public class ScoreOnTrigger : MonoBehaviour
{
    public GameObject player;
    
	public void OnTriggerEnter(Collider col)
	{
        if (col.GetComponent<Ball>().IsScored != true)
        {
            
            ScoreManager.UpdateScore();
            col.GetComponent<Ball>().IsScored = true;
        }
    }
}