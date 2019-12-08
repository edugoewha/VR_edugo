using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grab : MonoBehaviour
{
    public GameObject waterword;
    public GameObject ropeword;
    public GameObject grassword;
    public GameObject tangerineword;
    public GameObject rockword;
    public GameObject fireword;
    public GameObject myHand;
    Vector3 waterwordPos;
    Vector3 ropewordPos;
    Vector3 grasswordPos;
    Vector3 tangerinewordPos;
    Vector3 rockwordPos;
    Vector3 firewordPos;
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
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetButtonDown("Fire1"))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)){
            
                if(hit.collider.tag == "grassword"){
                    grassword.transform.SetParent(myHand.transform);
                    grassword.transform.localPosition = new Vector3(3.0f, 0.8f, 2.2f);
                    inHand1 = true;
                }
                
                if(hit.collider.tag == "waterword"){
                    waterword.transform.SetParent(myHand.transform);
                    waterword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand2 = true;
                }
                
                if(hit.collider.tag == "ropeword"){
                    ropeword.transform.SetParent(myHand.transform);
                    ropeword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand3 = true;
                }
                
                if(hit.collider.tag == "tangerineword"){
                    tangerineword.transform.SetParent(myHand.transform);
                    tangerineword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand4 = true;
                }
                
                if(hit.collider.tag == "rockword"){
                    rockword.transform.SetParent(myHand.transform);
                    rockword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand5 = true;
                }
                
                if(hit.collider.tag == "fireword"){
                    fireword.transform.SetParent(myHand.transform);
                    fireword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand6 = true;
                }
            }
            
        }


    }
}
