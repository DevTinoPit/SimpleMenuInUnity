using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using VirtualiSurg.Architecture;

[RequireComponent(typeof(TextMeshProUGUI))]

public class NameDisplayer : MonoBehaviour
{
    TextMeshProUGUI _displayText;
    [SerializeField] StringReadOnlyReference _nameString;

    private void Awake()
    {
        _displayText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        _displayText.text = "My Name";
    }

    public void UpdateName()
    {
        _displayText.text = _nameString.value;
    }
}
