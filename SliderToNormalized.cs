/**
 * @author Kleber Ribeiro da Silva
 * @email krsmga@gmail.com
 * @create date 2020-06-28 11:13:56
 * @modify date 2020-06-28 11:13:56
 * @desc This class can be used to transfer 'normalizedValue` from a Slider component (source) to other Sliders (destination).
 * @github https://github.com/krsmga/SliderToNormalized
 */
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This class can be used to transfer 'normalizedValue` from a Slider component (source) to other Sliders (destination).
/// </summary>
/// <remarks>
/// <param name="_slidersTo">Attach the sliders (destination) that will receive the value of 'normalizedValue'.</param>
/// </remarks>
public class SliderToNormalized : MonoBehaviour
{
    [SerializeField] private Slider[] _slidersTo = default;

    private Slider _sliderFrom;
    private float _normalizedValue;

    /// <summary>
    /// Receives a value from 0 to 1 for normalizedValue
    /// </summary>
    /// <returns>
    /// (float) -> 0 to 1
    /// </returns>
    public float normalizedValue
    {
        get { return _normalizedValue; }
        set
        {
            if (_normalizedValue != value)
            {
                _normalizedValue = value;
                for (int i = 0; i < _slidersTo.Length; i++)
                {
                    _slidersTo[i].normalizedValue = _normalizedValue;
                }
            }
        }
    }

    void Start()
    {
        _sliderFrom = GetComponent<Slider>();
    }

    void Update()
    {
        normalizedValue = _sliderFrom.normalizedValue;
    }
}
