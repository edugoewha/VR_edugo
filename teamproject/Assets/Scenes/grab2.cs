
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grab2 : MonoBehaviour
{
	public GameObject bananaword;
    public GameObject tigerword;
    public GameObject spoonword;
    public GameObject carword;
    public GameObject fishword;
    public GameObject elephantword;
    public GameObject myHand;
    Vector3 bananawordPos;
    Vector3 tigerwordPos;
    Vector3 spoonwordPos;
    Vector3 carwordPos;
    Vector3 fishwordPos;
    Vector3 elephantwordPos;
    Camera cam;
    public float handPower;
    public static bool inHand1;
    public static bool inHand2;
    public static bool inHand3;
    public static bool inHand4;
    public static bool inHand5;
    public static bool inHand6;

    Ray ray;
    RaycastHit hit;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
            
                if(hit.collider.tag == "bananaword"){
                    bananaword.transform.SetParent(myHand.transform);
                    bananaword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand1 = true;
                }
                
                if(hit.collider.tag == "tigerword"){
                    tigerword.transform.SetParent(myHand.transform);
                    tigerword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand2 = true;
                }
                
                if(hit.collider.tag == "spoonword"){
                    spoonword.transform.SetParent(myHand.transform);
                    spoonword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand3 = true;
                }
                
                if(hit.collider.tag == "carword"){
                    carword.transform.SetParent(myHand.transform);
                    carword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand4 = true;
                }
                
                if(hit.collider.tag == "fishword"){
                    fishword.transform.SetParent(myHand.transform);
                    fishword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand5 = true;
                }
                
                if(hit.collider.tag == "elephantword"){
                    elephantword.transform.SetParent(myHand.transform);
                    elephantword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
                    inHand6 = true;
                }
            }
            
        }

    }
}