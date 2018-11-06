using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class DivideValue : ScriptableObject 
{
	public FloatData ValueObj;
	public UnityEvent Event;

	public void DivideValuetoObj (FloatData data)
	{
		ValueObj.Value /= data.Value;
	}
}
