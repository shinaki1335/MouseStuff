using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    //variables for the game
    public SpriteRenderer sp;
    public Sprite newSprite;
    public Sprite originalSprite;

    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ChangeSprite();
            changed = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            ChangeSprite();
            changed = false;
        }
    }
    void ChangeSprite()
    {
        if (!changed)
        {
            sp.sprite = newSprite;
        }

        else
        {
            sp.sprite = originalSprite;
        }

    }
}
