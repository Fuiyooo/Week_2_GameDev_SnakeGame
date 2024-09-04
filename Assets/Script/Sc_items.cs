using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_items : MonoBehaviour
{
    GameObject snake;
    

    private void Awake(){
        snake = GameObject.Find("Snakes");
    }

    private void OnTriggerEnter(Collider other){
        Debug.Log("Kena : " + other.gameObject.name);
        snake.SendMessage("eatFruit");
        Destroy(this.gameObject);
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
