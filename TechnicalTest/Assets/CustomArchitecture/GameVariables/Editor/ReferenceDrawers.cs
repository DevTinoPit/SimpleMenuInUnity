using UnityEditor;
using UnityEngine;
using VirtualiSurg.Architecture;

[CustomPropertyDrawer(typeof(FloatReference))]
public class FloatReferenceDrawer : Architecture.Variables.GenericReferenceDrawer {}

[CustomPropertyDrawer(typeof(FloatReadOnlyReference))]
public class FloatReadOnlyReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(IntReference))]
public class IntReferenceDrawer : Architecture.Variables.GenericReferenceDrawer {}

[CustomPropertyDrawer(typeof(IntReadOnlyReference))]
public class IntReadOnlyReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(BoolReference))]
public class BoolReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(BoolReadOnlyReference))]
public class BoolReadOnlyReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(StringReference))]
public class StringReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(StringReadOnlyReference))]
public class StringReadOnlyReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(GameObjectReference))]
public class GameObjectReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }

[CustomPropertyDrawer(typeof(GameObjectReadOnlyReference))]
public class GameObjectReadOnlyReferenceDrawer : Architecture.Variables.GenericReferenceDrawer { }
