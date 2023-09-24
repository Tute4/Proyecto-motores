using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEditor;

public class Meta : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI WinText;
    void Start()
    {
        WinText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("Entro al trigger: " + other.gameObject.name);

        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entro el player");

            WinText.enabled = true;
            
        }
    }
}
