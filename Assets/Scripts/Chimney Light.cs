using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChimneyLight : MonoBehaviour
{
    [SerializeField]
    private Light _light;

    const int MAX_LIGHT_LEVEL = 45;
    const int MIN_LIGHT_LEVEL = 5;

    float _lightLevelChange = 5;
    float _lightLevel = MAX_LIGHT_LEVEL;

    void Update()
    {
        _lightLevel += _lightLevelChange * Time.deltaTime * 5;
        _light.intensity = _lightLevel;
        _light.range = _lightLevel/2;

        if (_lightLevel > MAX_LIGHT_LEVEL || _lightLevel< MIN_LIGHT_LEVEL) {
            _lightLevelChange *= -1;
        }
    }
}
