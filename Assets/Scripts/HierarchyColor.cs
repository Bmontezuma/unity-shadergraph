using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public static class HierarchyColor
{
    static HierarchyColor()
    {
        EditorApplication.hierarchyWindowItemOnGUI += OnHierarchyGUI;
    }

    private static void OnHierarchyGUI(int instanceID, Rect selectionRect)
    {
        GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;
        if (obj != null)
        {
            // Change color based on the object name
            if (obj.name.StartsWith("Main"))
                EditorGUI.DrawRect(selectionRect, new Color(0.2f, 0.6f, 1f, 0.5f)); // Light blue
            else if (obj.name.StartsWith("Enemy"))
                EditorGUI.DrawRect(selectionRect, new Color(1f, 0.3f, 0.3f, 0.5f)); // Red
            else if (obj.name.StartsWith("UI"))
                EditorGUI.DrawRect(selectionRect, new Color(0.5f, 1f, 0.5f, 0.5f)); // Green
        }
    }
}
