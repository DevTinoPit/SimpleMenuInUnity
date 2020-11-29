using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using DG.Tweening;

[RequireComponent(typeof(TextMeshProUGUI))]

public class ErrorDisplayer : MonoBehaviour
{
    TextMeshProUGUI _displayText;

    [Header("Parameters"), SerializeField] string _invalidCharacterErrorMsg;
    [SerializeField] string _noCharactersErrorMsg;

    private void Awake()
    {
        _displayText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        RemoveErrorMessage();
    }

    public void DisplayErrorMessage(String pErrorType)
    {
        switch (pErrorType)
        {
            case "NoCharacters":
                _displayText.text = _noCharactersErrorMsg;
                break;
            case "InvalidCharacter":
                _displayText.text = _invalidCharacterErrorMsg;
                break;
            default:
                break;
        }
        transform.DOShakePosition(.5f, 5f);
    }

    public void RemoveErrorMessage()
    {
        _displayText.text = "";
    }
}
