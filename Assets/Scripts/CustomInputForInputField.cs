using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CustomInputForInputField : MonoBehaviour
{
    private TMP_InputField inputField;

    [Header("Input Settings")]
    [SerializeField] private bool charLimitNumber = false;
    [Range(0, 10)]
    [SerializeField] private int numberOfChar = 2;


    public bool acceptOnlyNumbers = false;
    [SerializeField] private bool acceptOnlyAlphabets = false;

    private void Start()
    {

        inputField = GetComponent<TMP_InputField>();


        // Subscribe to the onValueChanged event
        inputField.onValueChanged.AddListener(ValidateInput);
    }

    private void ValidateInput(string input)
    {
        string validInput = "";

        // Determine which validation rule to apply
        if (acceptOnlyNumbers)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    validInput += c; // Allow only numeric characters
                }
            }
        }
        else if (acceptOnlyAlphabets)
        {
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    validInput += c; // Allow only alphabetic characters
                }
            }
        }
        else
        {
            validInput = input; // Allow all characters if no specific rule is applied
        }

        // Enforce character limit if enabled
        if (charLimitNumber && validInput.Length > numberOfChar)
        {
            validInput = validInput.Substring(0, numberOfChar); // Trim to max length
        }

        // Update the InputField text only if changes were made
        if (validInput != input)
        {
            inputField.text = validInput; // This will internally trigger onValueChanged
            inputField.caretPosition = validInput.Length; // Maintain caret position
        }
    }
}
