using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milk : MonoBehaviour
{
    public GameObject Milkword;
    void OnMouseDown()
    {
        if (grab3.inHand)
            Destroy(Milkword);
    }
}
