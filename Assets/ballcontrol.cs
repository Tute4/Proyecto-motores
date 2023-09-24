using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ballcontrol : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;
    [SerializeField] private float force;
    [SerializeField] private int score;
    private int totalItems;
    [SerializeField] TextMeshProUGUI scoreText;

    void Start()
    {
        
        totalItems = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = score.ToString() + " / " + totalItems.ToString();
    }

    private void FixedUpdate()
    {
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(inputHorizontal, 0f, inputVertical);

        rigidBody.AddForce(direction * force, ForceMode.Force);
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Choque contra: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Item"))
        {
            Debug.Log("ITEMMMMMMMMMMMM");


            Destroy(collision.gameObject);
            score++;
            scoreText.text = score.ToString() + " / " + totalItems.ToString();
        }
        if (collision.gameObject.CompareTag("Kill"))
        {
            SceneManager.LoadScene(0);
        }
        
    }
}
