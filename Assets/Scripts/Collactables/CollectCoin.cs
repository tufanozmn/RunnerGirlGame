using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        CollactableControl.coinCount += 1;
        this.gameObject.SetActive(false);
        Debug.Log("Test");
    }
    
}
