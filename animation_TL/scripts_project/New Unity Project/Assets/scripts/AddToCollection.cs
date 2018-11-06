using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddtoCollection : ScriptableObject {
	
	public ObjectCollection  Collection;

	public void Call(ScriptableObject obj)
	{
		Collection.ObjectList.Add(obj); 
	}

}
