using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{


    public GameObject SwordsOnPlayer;
    void Start()
    {
        SwordsOnPlayer.SetActive(false);    
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                SwordsOnPlayer.SetActive(true);
            }
        }
    }
   
   
}
