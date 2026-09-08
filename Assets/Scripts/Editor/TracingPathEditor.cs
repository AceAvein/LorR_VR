using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TracingPath))]
public class TracingPathEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        TracingPath path = (TracingPath)target;

        GUILayout.Space(10);
        GUILayout.Label("Auto-Generate Shape");

        if (GUILayout.Button("Generate Circle"))
        {
            path.pathPoints = PathGenerator.GenerateCircle(0.15f, 32);
            EditorUtility.SetDirty(path);
        }
        if (GUILayout.Button("Generate Wave"))
        {
            path.pathPoints = PathGenerator.GenerateWave(0.4f, 0.1f, 32);
            EditorUtility.SetDirty(path);
        }
    }
}