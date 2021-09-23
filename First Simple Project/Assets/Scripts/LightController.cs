using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    private Light SceneLight;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello, World! I'm a Light");
        SceneLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            SceneLight.enabled = !SceneLight.enabled;
        }
    }
}
