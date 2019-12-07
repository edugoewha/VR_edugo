using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chair : MonoBehaviour
{
    public GameObject Chairword;
    void OnMouseDown()
    {
        if (grab3.inHand1)
            Destroy(Chairword);
    }
}
