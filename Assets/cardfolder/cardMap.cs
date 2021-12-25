using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cardMap : MonoBehaviour
{
    public Text name;
    public Text desc;
    public Text attack;
    public Text health;
    public int healthi;
    public int attacki;
    public Text manaCount;
    public Image artwork;
    public Card card;
    // Start is called before the first frame update
    /*void Start()
    {
        name.text = card.name;
        desc.text = card.desc;
        attack.text = card.attack+"";
        health.text = card.health+"";
        attacki = card.attack;
        healthi = card.health;
        manaCount.text = card.manaCount+"";
        artwork.sprite = card.artwork;
    }
    */
    // Update is called once per frame
    void Update()
    {
        
    }
    public void choose(Card c)
    {

    }
    public void changeCard(Card c)
    {
        name.text = c.name;
        desc.text = c.desc;
        attack.text = c.attack + "";
        health.text = c.health + "";
        manaCount.text = c.manaCount + "";
        artwork.sprite = c.artwork;
        attacki = c.attack;
        healthi = c.health;
    }
    public void changeImg(Image art)
    {
        artwork = art;
    }
    public void changeName(string s)
    {
        name.text = s;
        card.name = s;
    }
    public void changeHealth()
    {
        healthi += 1;
        health.text = healthi + "";
    }
    public void changeAttack()
    {
        attacki += 1;
        attack.text = attacki + "";
    }
}
