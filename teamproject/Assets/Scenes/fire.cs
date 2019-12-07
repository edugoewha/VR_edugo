using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{
    public GameObject fireword;
    
     
     void OnMouseDown(){
             
        if(grab.inHand6)
             Destroy(fireword);
         
     }
}
