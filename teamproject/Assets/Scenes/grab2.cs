using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class grab2 : MonoBehaviour
{
	public GameObject bananaword;
    public GameObject myHand;
    Vector3 bananawordPos;
    Camera cam;
    public float handPower;
    public static bool inHand;
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
            bananaword.transform.SetParent(myHand.transform);
            bananaword.transform.localPosition = new Vector3(0.8f, 0.8f, 0);
            inHand = true;
        }
    }
}
