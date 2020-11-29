using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using VirtualiSurg.Architecture;

public class StringVariableWriter : MonoBehaviour
{
    [SerializeField] TMP_InputField _inputField;
    [SerializeField] StringVariable _operatedStringVariable;
    [SerializeField] GameEvent _nameUpdated;

    string _checkString;

    private void Start()
    {
        if (_inputField != null || _operatedStringVariable != null)
            StartCoroutine(Write());
        else
            Debug.LogWarning("Please link requiered references.");
    }

    /// <summary>
    /// Manage association of text input and operated string variable
    /// </summary>
    /// <returns></returns>
    private IEnumerator Write()
    {
        _checkString = _inputField.text;
        while (true)
        {
            if (_inputField.text != _checkString)
            {
                _operatedStringVariable.CurrentValue = _inputField.text;
                _checkString = _inputField.text;
                _nameUpdated.Raise();
            }
            yield return null;
        }
    }

    public void EraseInput()
    {
        _inputField.text = "";
    }
}
