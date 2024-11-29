using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HintInputField : MonoBehaviour
{
 

    [SerializeField] private TMP_InputField hintInputField;
    [SerializeField] private TMP_InputField numberOfWordInputField;


 
    [SerializeField] private ScrollView scrollView;
    [SerializeField] private Transform scrollViewVontentTransform;
   

    private void Start()
    {
      
    }
    private void Update()
    {
         
    }

    public void OnClickOk()
    {
       

        if (hintInputField != null && numberOfWordInputField != null)
        {
            if (string.IsNullOrWhiteSpace(hintInputField.text)) 
            {

                Debug.Log("Write your hint Plz");
            
            }
            if (string.IsNullOrWhiteSpace(numberOfWordInputField.text))
            {
                Debug.Log("Write your number of world");
            }

            
            else if (!string.IsNullOrWhiteSpace(numberOfWordInputField.text) && !string.IsNullOrWhiteSpace(hintInputField.text))
            {






               
                

              
                GameObject newText =  Instantiate( new GameObject()  , scrollViewVontentTransform   ) ;

               
             




                TextMeshProUGUI textComponent = newText.AddComponent<TextMeshProUGUI>();
                textComponent.text = (hintInputField.text + " + " + numberOfWordInputField.text);


            }
        }
        
    }
}
