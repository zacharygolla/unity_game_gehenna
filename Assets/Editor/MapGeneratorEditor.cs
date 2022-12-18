using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor 
{
    public override void OnInspectorGUI()
    {
        MapGenerator mapGenerator = target as MapGenerator;

        if(DrawDefaultInspector())
        {
            if(mapGenerator.autoUpdate)
            {
                mapGenerator.GenerateMap();
            }
        }

        if(GUILayout.Button("Generate"))
        {
            mapGenerator.GenerateMap();
        }
    }
}
