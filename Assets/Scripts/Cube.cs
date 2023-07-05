using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    public Cube()
    {
        this.Name = "Cube";
        this.Color = new Color(0.5f, 0.5f, 1f);
        this.Speed = 1.5f;
    }

    // POLYMORPHISM
    public override void RotateShape()
    {
        transform.Rotate(Vector3.back, Speed);
    }

    private void OnMouseDown()
    {
        Debug.Log("Cube clicked");
        UpdateText(this.Name, this.Speed, "blue"); // ABSTRACTION
    }
}
