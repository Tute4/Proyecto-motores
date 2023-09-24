using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class capsuleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(0,10f)] private float movementSpeed;
    [SerializeField] private float inputHorizontal;
    [SerializeField] private float inputVertical;
    [Header("un titulo")]
    [SerializeField] private Vector3 movementVector;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      /*  if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed); // 10 fps delta 0.1         1 segundo 10 cuadros 10 * 0,1 = 1
                                                                                // 20 fps delta 0.05        1 segundo 20 cuadros 20 * 0.05 = 1
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
      */

        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        movementVector = new Vector3(inputHorizontal, 0f, inputVertical);

        movementVector.Normalize();

        transform.Translate(movementVector * Time.deltaTime * movementSpeed);
    }
}
