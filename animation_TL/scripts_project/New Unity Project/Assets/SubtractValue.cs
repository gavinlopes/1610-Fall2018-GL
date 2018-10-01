using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class SubtractValue : ScriptableObject
{
	public FloatData ValueObj;
	public UnityEvent Event;

	public void SubtractValuetoObj (FloatData data)
	{
		ValueObj.Value -= data.Value;
	}
}
