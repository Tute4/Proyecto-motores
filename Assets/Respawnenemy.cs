using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawnenemy : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.transform.position;
        }
    }
}
