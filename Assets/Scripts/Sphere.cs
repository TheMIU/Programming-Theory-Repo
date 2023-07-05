using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Sphere : Shape
{
    public Sphere()
    {
        this.Name = "Sphere";
        this.Color = new Color(1f, 0.5f, 0.5f);
        this.Speed = 1f;
    }

    // POLYMORPHISM
    public override void RotateShape()
    {
        transform.Rotate(Vector3.up, Speed);
    }

    private void OnMouseDown()
    {
        Debug.Log("Sphere clicked");
        UpdateText(this.Name, this.Speed, "red"); // ABSTRACTION
    }
}
