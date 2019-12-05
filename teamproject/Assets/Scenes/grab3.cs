using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grab3 : MonoBehaviour
{
    public GameObject Milkword;
    public GameObject Chairword;
    public GameObject Penword;
    public GameObject Umbrellaword;
    public GameObject Duckword;
    public GameObject Monkeyword;
    public GameObject myHand;
    Vector3 MilkwordPos;
    Vector3 ChairwordPos;
    Vector3 PenwordPos;
    Vector3 UmbrellawordPos;
    Vector3 DuckwordPos;
    Vector3 MonkeywordPos;
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
            if (Physics.Raycast(ray, out hit))
            {

                if (hit.collider.tag == "Monkey")
                {
                    Monkeyword.transform.SetParent(myHand.transform);
                    Monkeyword.transform.localPosition = new Vector3(3.0f, 0.8f, 2.2f);
                    inHand1 = true;
                }

                if (hit.collider.tag == "Milk")
                {
                    Milkword.transform.SetParent(myHand.transform);
                    Milkword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand2 = true;
                }

                if (hit.collider.tag == "Chair")
                {
                    Chairword.transform.SetParent(myHand.transform);
                    Chairword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand3 = true;
                }

                if (hit.collider.tag == "Pen")
                {
                    Penword.transform.SetParent(myHand.transform);
                    Penword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand4 = true;
                }

                if (hit.collider.tag == "Rock")
                {
                    Umbrellaword.transform.SetParent(myHand.transform);
                    Umbrellaword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand5 = true;
                }

                if (hit.collider.tag == "Duck")
                {
                    Duckword.transform.SetParent(myHand.transform);
                    Duckword.transform.localPosition = new Vector3(0, 0.8f, 0);
                    inHand6 = true;
                }
            }

        }


    }
}