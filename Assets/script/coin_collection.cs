using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_collection : MonoBehaviour
{

    private Vector3 Coinposition;
    // this is the default unity function that will be called whenever two objects collide and one has the Trigger parameter enabled
    // the argument "other" refers to the object that hits the game object this script is attached to. 
    private void OnTriggerEnter(Collider other)
    {
        // In this case the we want to check if the "other" is the "Ball"
        // Make sure your ball gameobject is named “Ball”, otherwise you will receive an error!
        if (other.name == "Ball")
        {
            // if this condition is correct and indeed the Ball game object has hit this game object where the script is attached (i.e. the coin), we will remove this game object
            //Destroy(this.gameObject);
            Debug.Log("test");
            Coinposition = new Vector3(Random.Range(-4.0f,4.0f), 0.5f, Random.Range(-4.0f, 4.0f));
            this.transform.position = Coinposition;

        }
    }
}