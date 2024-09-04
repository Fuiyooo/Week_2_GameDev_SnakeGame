using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sc_snake : MonoBehaviour
{
    
    float turnSpeed = 1f;
    float speed = 3f;
    [SerializeField] GameObject objBuntut;

    private float tailDistance = 0.5f;
    private List<Transform> tailSegments = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self);

        float h = Input.GetAxis("Horizontal");
        this.transform.Rotate(Vector3.up * h * turnSpeed);

        if(tailSegments.Count > 0){
            Vector3 previousPosition = this.transform.position;

            for(int i = 0; i < tailSegments.Count; i++){
                Vector3 currentSegmentPosition = tailSegments[i].position;
                tailSegments[i].position = Vector3.Lerp(currentSegmentPosition, previousPosition, Time.deltaTime * speed / tailDistance);
                previousPosition = currentSegmentPosition;
            }
        }
    }

    public void eatFruit(){
        Debug.Log("Snake Makan Item");
        AddTailSegment();
    }

    public void AddTailSegment(){
        Vector3 newSegmentPositions = (tailSegments.Count == 0) ? this.transform.position : tailSegments[tailSegments.Count - 1].position;
        GameObject newSegment = Instantiate(objBuntut, newSegmentPositions, Quaternion.identity);
        tailSegments.Add(newSegment.transform);
    }

    /*
    public void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("tail")){
            Debug.Log("Snakes head hit the tail. Game Over!");
            Destroy(gameObject);
        }
    }
    */
}
