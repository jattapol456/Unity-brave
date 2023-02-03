using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SIgn : MonoBehaviour
{
    public GameObject dialogBox;
    public TMP_Text dialogText;
    public string dialog;
    public bool playerInRage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G) && playerInRage)
        {
            if(dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }else{
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            playerInRage = true;
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if(other.CompareTag("Player"))
        {
            playerInRage = false;
            dialogBox.SetActive(false);
        }
    }
}
 