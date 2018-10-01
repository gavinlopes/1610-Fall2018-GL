using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class MultipleValue : ScriptableObject 
{
	public FloatData ValueObj;
	public UnityEvent Event;

	public void MultipleValuetoObj (FloatData data)
	{
		ValueObj.Value x= data.Value;
	}
}
