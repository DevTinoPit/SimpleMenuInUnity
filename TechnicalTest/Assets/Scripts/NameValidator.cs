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

    public void Validate()
    {
        string lSavedString = _enterString.value;

        if (lSavedString.Length <= 0)
        {
            _noCharactersEvent.Raise();
            return;
        }

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
}
