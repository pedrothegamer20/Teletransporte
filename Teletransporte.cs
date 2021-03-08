using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class Teletransporte : MonoBehaviour 
{ 

public Transform Teleport; 

void OnTriggerEnter(Collider col) 
 { 

    if(col.transform.CompareTag("Player")) 
    { 
        col.transform.position = Teleport.position; 
    }
 
 } 

}
