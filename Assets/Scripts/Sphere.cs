using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public Sphere()
    {
        this.Name = "Sphere";
        this.Color = new Color(1f, 0.5f, 0.5f); // Pastel red
        this.Speed = 1f;
    }

    public override void RotateShape()
    {
        transform.Rotate(Vector3.up, Speed); //Rotates around the Y-axis
    }

    private void OnMouseDown()
    {
        Debug.Log("Sphere clicked");
        UpdateText(this.Name, this.Speed, "red");
    }
}
