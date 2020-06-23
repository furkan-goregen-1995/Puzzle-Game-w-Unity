using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    
    public SpriteRenderer spriteRenderer;
    public Sprite sprite;
    public SphereCollider coll;

//Circle value assignment
private void Start() {
    sprite = Resources.Load <Sprite> ("Pngs/Circle");
    spriteRenderer = gameObject.AddComponent<SpriteRenderer>();
    spriteRenderer.sprite = sprite;
    coll = gameObject.AddComponent<SphereCollider>();
}
    //Change circle color
    public void ChangeColor(Color clr){

        GetComponent<SpriteRenderer>().material.color = clr;

    }

}
