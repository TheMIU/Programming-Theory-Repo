using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// INHERITANCE
public class Shape : MonoBehaviour
{
    public TextMeshProUGUI shapeDetailsText;
    protected string shapeDetails;

    // ENCAPSULATION
    public string Name { get; set; }
    public Color Color { get; set; }
    public float Speed { get; set; }

    private void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color;
        shapeDetailsText.text = "Select shape";
    }

    private void Update()
    {
        RotateShape();
    }

    public virtual void RotateShape() { }

    public void UpdateText(string name, float speed, string color)
    {
        shapeDetailsText.text = $"{name} \nSpeed:{speed} \nColor:{color}";
    }
}

