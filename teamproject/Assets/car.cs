using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class car : MonoBehaviour
{
    public GameObject carword;
    public Text status;
	void Start(){
		status = gameObject.GetComponentInChildren<Text>();

	}
    void OnMouseDown(){
    	if(grab2.inHand4)
    		Destroy(carword);
    	
    }
}
