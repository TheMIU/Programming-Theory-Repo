using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    public Cube()
    {
        this.Name = "Cube";
        this.Color = new Color(0.5f, 0.5f, 1f); // Pastel blue
        this.Speed = 1.5f;
    }

    public override void RotateShape()
    {
        transform.Rotate(Vector3.back, Speed); //Rotates around the X-axis
    }

    private void OnMouseDown()
    {
        Debug.Log("Cube clicked");
        UpdateText(this.Name, this.Speed, "blue");
    }
}
