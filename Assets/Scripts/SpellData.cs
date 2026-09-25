using UnityEngine;

[CreateAssetMenu(fileName = "New Spell", menuName = "New Spell/Spell Data")]
public class SpellData : ScriptableObject
{
    public string spellName;
    [TextArea] public string spellCode;
    public int tier;
    public int baseDamage;
}