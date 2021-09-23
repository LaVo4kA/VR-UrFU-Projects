using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private Material SphereMaterial;
    private Dictionary<Color, Color> colors = new Dictionary<Color, Color>()
    {
        { Color.red, Color.yellow },
        { Color.yellow, Color.green },
        { Color.green, Color.red }
    };
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, World! I'm a Sphere");
        SphereMaterial = GetComponent<MeshRenderer>().material;
        SphereMaterial.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            SphereMaterial.color = colors[SphereMaterial.color];
        }
    }
}
