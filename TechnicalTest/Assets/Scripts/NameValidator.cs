using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualiSurg.Architecture;

public class NameValidator : MonoBehaviour
{
    [Header("Editor references"), SerializeField] GameEvent _validEvent;
    [SerializeField] GameEvent _invalidCharactersEvent;
    [SerializeField] GameEvent _noCharactersEvent;

    [Space, SerializeField] StringReadOnlyReference _enterString;
    [SerializeField] StringVariable _validatedNameVariable;

    [Header("Parameters"), SerializeField] char[] _invalidCharacters;

    private void Start()
    {
        _validatedNameVariable.CurrentValue = "MyName";
    }

    public void Validate()
    {
        string lSavedString = _enterString.value;

        //If the string is empty return error
        if (lSavedString.Length <= 0)
        {
            _noCharactersEvent.Raise();
            return;
        }

        //If the string contains any banned character, return error
        for (int i = 0; i < lSavedString.Length; i++)
        {
            for (int j = 0; j < _invalidCharacters.Length; j++)
            {
                if(lSavedString[i] == _invalidCharacters[j])
                {
                    _invalidCharactersEvent.Raise();
                    return;
                }
            }
        }
        _validatedNameVariable.CurrentValue = _enterString.value;
        _validEvent.Raise();
    }

    public void ResetName()
    {
        _validatedNameVariable.CurrentValue = "MyName";
        _validEvent.Raise();
    }
}
