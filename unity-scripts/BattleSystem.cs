using UnityEngine;

public class BattleSystem : MonoBehaviour
{
    public enum Element { Metal, Wood, Water, Fire, Earth }
    public SemanticSoulEngine soulEngine;
    public float playerHealth = 100f;
    public float enemyHealth = 100f;

    public float CalculateDamage(Element attacker, Element defender, float baseDamage)
    {
        float damage = baseDamage;
        if (IsStrongAgainst(attacker, defender))
        {
            damage *= 1.5f; // 相剋加成
        }
        else if (IsWeakAgainst(attacker, defender))
        {
            damage *= 0.5f; // 相剋減弱
        }
        if (soulEngine.emotionVector["BondAffinity"] > 0.7f)
        {
            damage *= 1.1f; // 羈絆加成
        }
        return damage;
    }

    private bool IsStrongAgainst(Element attacker, Element defender)
    {
        return (attacker == Element.Metal && defender == Element.Wood) ||
               (attacker == Element.Wood && defender == Element.Earth) ||
               (attacker == Element.Earth && defender == Element.Water) ||
               (attacker == Element.Water && defender == Element.Fire) ||
               (attacker == Element.Fire && defender == Element.Metal);
    }

    private bool IsWeakAgainst(Element attacker, Element defender)
    {
        return IsStrongAgainst(defender, attacker);
    }

    public void Attack(Element playerElement, Element enemyElement)
    {
        float damage = CalculateDamage(playerElement, enemyElement, 10f);
        enemyHealth -= damage;
        Debug.Log($"對敵人造成 {damage} 傷害，敵人剩餘血量：{enemyHealth}");
    }
}