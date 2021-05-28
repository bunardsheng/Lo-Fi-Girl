using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour {

    public Sprite newSprite;

    // replaces old sprite with new sprite
    public void ChangeSprite()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
