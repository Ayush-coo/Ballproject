using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player")
        {
            gameObject.SetActive(false);
        }
    }
}


  
