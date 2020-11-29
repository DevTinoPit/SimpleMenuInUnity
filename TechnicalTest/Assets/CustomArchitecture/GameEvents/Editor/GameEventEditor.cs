using UnityEngine;
using UnityEditor;
using VirtualiSurg.Architecture;

    [CustomEditor(typeof(GameEvent))]
    public class GameEventEditor : Editor
    {
        int intInput = 0;
        float floatInput = 0;
        string stringInput = "";
        bool boolInput = false;
        Object objectInput = null;
        GameObject gameObjectInput = null;
        Transform transformInput = null;

        public override void OnInspectorGUI()
        {
            // Retrieve target
            GameEvent customEvent = (GameEvent)target;

            // Button to raise simple event
            EditorGUILayout.LabelField("Simple event", EditorStyles.boldLabel);
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise();
            }

            // Button to raise event with int
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with int", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            intInput = EditorGUILayout.IntField("Int:", intInput, GUILayout.MaxWidth(90f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(intInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with float
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with float", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            floatInput = EditorGUILayout.FloatField("Float:", floatInput, GUILayout.MaxWidth(90f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(floatInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with bool
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with bool", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            boolInput = EditorGUILayout.Toggle("Bool:", boolInput, GUILayout.MaxWidth(90f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(boolInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with string
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with string", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            stringInput = EditorGUILayout.TextField("String:", stringInput, GUILayout.MaxWidth(200f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(stringInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with object
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with object", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            objectInput = EditorGUILayout.ObjectField("Object:", objectInput, typeof(Object), true, GUILayout.MaxWidth(200f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(objectInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with GameObject
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with gameObject", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            gameObjectInput = (GameObject)EditorGUILayout.ObjectField("GameObject:", gameObjectInput, typeof(GameObject), true, GUILayout.MaxWidth(200f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(gameObjectInput);
            }
            GUILayout.EndHorizontal();

            // Button to raise event with object
            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Event with transform", EditorStyles.boldLabel);
            GUILayout.BeginHorizontal();
            EditorGUIUtility.labelWidth = 50f;
            transformInput = (Transform)EditorGUILayout.ObjectField("Transform:", transformInput, typeof(Transform), true, GUILayout.MaxWidth(200f));
            if (GUILayout.Button("Raise"))
            {
                customEvent.Raise(transformInput);
            }
            GUILayout.EndHorizontal();
        }
    }
