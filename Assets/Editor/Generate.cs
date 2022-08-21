using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(DungeonGenerator))]
public class Generate : Editor
{
    public override void OnInspectorGUI()
    {
        DungeonGenerator generate = (DungeonGenerator)target;
        
        base.OnInspectorGUI();

        if(GUILayout.Button("Generate"))
        {
            generate.ClearObjects();
            generate.MazeGenerator();
        }

        if (GUILayout.Button("Clear"))
        {
            generate.ClearObjects();
        }
    }
}
