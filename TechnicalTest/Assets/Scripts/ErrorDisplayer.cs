using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using DG.Tweening;

[RequireComponent(typeof(TextMeshProUGUI))]
[RequireComponent(typeof(AudioSource))]

public class ErrorDisplayer : MonoBehaviour
{
    TextMeshProUGUI _displayText;
    AudioSource _audioComp;

    [Header("Parameters"), SerializeField] string _invalidCharacterErrorMsg;
    [SerializeField] string _noCharactersErrorMsg;
    [SerializeField] string _loadErrorMsg;

    private void Awake()
    {
        _displayText = GetComponent<TextMeshProUGUI>();
        _audioComp = GetComponent<AudioSource>();
    }

    private void Start()
    {
        RemoveErrorMessage();
    }

    /// <summary>
    /// Display error message according to parameter & launch sfx
    /// </summary>
    /// <param name="pErrorType"></param>
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
            case "LoadError":
                _displayText.text = _loadErrorMsg;
                break;
            default:
                break;
        }
        transform.DOShakePosition(.5f, 5f);
        _audioComp.Play();
    }

    public void RemoveErrorMessage()
    {
        _displayText.text = "";
    }
}
