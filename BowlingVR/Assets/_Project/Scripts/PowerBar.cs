using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerBar : MonoBehaviour {


    
    public GameObject powerBar;
    public Color weakColor;
    public Color averageColor;
    public Color strongColor;

    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {

            
            powerBar.GetComponent<Scrollbar>().size += 0.005f;
            float totalValue = powerBar.GetComponent<Scrollbar>().size;

            SetPower(totalValue);
            

        }
        else if (Input.GetMouseButtonUp(0))
        {
            powerBar.GetComponent<Scrollbar>().size = 0;
        }
		
	}

    public void SetPower(float value)
    {
        powerBar.GetComponent<Scrollbar>().size += value * Time.deltaTime;
        SetColor(value);

    }

    public void SetColor(float value)
    {
        if (value <= 0.5f)
        {
            powerBar.transform.Find("Mask").Find("Sprite").GetComponent<Image>().color = weakColor;
        }
        else if (value <= 0.75f && value > 0.5f)
        {
            powerBar.transform.Find("Mask").Find("Sprite").GetComponent<Image>().color = averageColor;
        }
        else
        {
            powerBar.transform.Find("Mask").Find("Sprite").GetComponent<Image>().color = strongColor;
        }
    }
}
