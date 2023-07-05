using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public Cylinder()
    {
        this.Name = "Cylinder";
        this.Color = new Color(0.5f, 1f, 0.5f); // Pastel green 
        this.Speed = 0.5f;
    }

    public override void RotateShape()
    {
        transform.Rotate(Vector3.right, Speed); //Rotates around the x-axis
    }

    private void OnMouseDown()
    {
        Debug.Log("Cylinder clicked");
        UpdateText(this.Name, this.Speed, "green");
    }
}
