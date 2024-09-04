using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_dead : MonoBehaviour
{

    GameObject tailSegment;

    private void Dead(){
        tailSegment = GameObject.Find("tailSegment");
    }

    public void OnTriggerEnter(Collider other){
        Debug.Log("U r ded!");
        Dead();
        Destroy(this.gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
