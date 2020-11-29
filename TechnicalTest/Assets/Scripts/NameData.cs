using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VirtualiSurg.Architecture;

[System.Serializable]
public class Name
{
    public string name;
}

public class NameData : MonoBehaviour
{
    [SerializeField] StringVariable _validatedName;
    [SerializeField] GameEvent _nameLoadedEvent;
    [SerializeField] GameEvent _nameSavedEvent;
    [SerializeField] GameEvent _noCharactersEvent;
    [SerializeField] GameEvent _loadingErrorEvent;

    Name _name = new Name();
    Name _loadedName;

    public void SaveName()
    {
        //Considerd as No name input
        if(_validatedName.CurrentValue == "MyName")
        {
            _noCharactersEvent.Raise();
            return;
        }

        //Get last validated name and store it in JSon file
        _name.name = _validatedName.CurrentValue;
        string lSavingName = JsonUtility.ToJson(_name);
        System.IO.File.WriteAllText(Application.dataPath + "/Name.json", lSavingName);
        _nameSavedEvent.Raise();
    }

    public void LoadName()
    {
        
        if (System.IO.File.Exists(Application.dataPath + "/Name.json"))
        {
            //Load last saved name and update the current validated name
            string lLoadedJson =  System.IO.File.ReadAllText(Application.dataPath + "/Name.json");

            _loadedName = JsonUtility.FromJson<Name>(lLoadedJson);
            _validatedName.CurrentValue = _loadedName.name;
            _nameLoadedEvent.Raise();
        }
        else
        {
            _loadingErrorEvent.Raise();
        }
    }
}
