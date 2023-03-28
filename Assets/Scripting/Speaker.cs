using UnityEngine;

[CreateAssetMenu(fileName = "Speaker", menuName = "Data/New Speaker")]
[System.Serializable]

public class Speaker : ScriptableObject
{
    public string speakerName; 
    public Color textColor;
}
