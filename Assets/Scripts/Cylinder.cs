using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    public Cylinder()
    {
        this.Name = "Cylinder";
        this.Color = new Color(0.5f, 1f, 0.5f);
        this.Speed = 0.5f;
    }

    // POLYMORPHISM
    public override void RotateShape()
    {
        transform.Rotate(Vector3.right, Speed); 
    }

    private void OnMouseDown()
    {
        Debug.Log("Cylinder clicked");
        UpdateText(this.Name, this.Speed, "green"); // ABSTRACTION
    }
}
