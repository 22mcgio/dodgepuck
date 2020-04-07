using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuckController : MonoBehaviour
{
    public float puckSpeed = 5.0f;
    public int[] direction = { 0, 1, 2, 3 };
    public int moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = direction[Random.Range(0, 4)];
        Debug.Log("moveDirection = " + moveDirection);
    }

    // Update is called once per frame
    void Update()
    {
        if (moveDirection == 0)
        {
            transform.Translate(transform.up * puckSpeed * Time.deltaTime);
        }
        
        if (moveDirection == 1)
        {
            transform.Translate(transform.right * puckSpeed * Time.deltaTime);
        }
        
        if (moveDirection == 2)
        {
            transform.Translate(transform.up * -puckSpeed * Time.deltaTime);
        }
        
        if (moveDirection == 3)
        {
            transform.Translate(transform.right * -puckSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("WAAAAAALLLLLLLLLLLLL");
        puckSpeed = -puckSpeed;
    }

}
