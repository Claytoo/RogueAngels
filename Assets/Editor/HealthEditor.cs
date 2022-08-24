using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthSystem))]
public class HealthEditor : Editor
{
    private HealthSystem health;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        health = (HealthSystem)target;

        health.useScriptable = EditorGUILayout.Toggle("Use Scriptable?", health.useScriptable);

        if (health.useScriptable)
        {
            health.healthScriptable = (ScriptableInteger)EditorGUILayout.ObjectField("Health", health.healthScriptable, typeof(ScriptableInteger), true);
            health.maxHealthScriptable = (ScriptableInteger)EditorGUILayout.ObjectField("Max Health", health.maxHealthScriptable, typeof(ScriptableInteger), true);
        }

        else
        {
            health.health = EditorGUILayout.IntField("Health", health.health);
            health.maxHealth = EditorGUILayout.IntField("Max Health", health.maxHealth);
        }
    }
}
