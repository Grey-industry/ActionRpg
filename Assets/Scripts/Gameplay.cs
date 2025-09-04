using TMPro;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Character
{
    public string name;
    public int hp;
    public Character(string n, int h)
    { 
        name = n;
        hp = h;
    }
}
public class Gameplay : MonoBehaviour
{
    TextMeshProUGUI playername;
    Image HpBar;
    Character player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = new Character("HARUKO", 100);
        playername = GameObject.Find("Playername").GetComponent<TextMeshProUGUI>();
        HpBar = GameObject.Find("HP").GetComponentInParent<Image>();
        playername.text = player.name;
    }

    // Update is called once per frame
    void Update()
    {
        HpBar.fillAmount = (float)player.hp / 100;
    }
}
