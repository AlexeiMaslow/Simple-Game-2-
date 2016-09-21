using UnityEngine;
using System.Collections;

public class Adhesion : MonoBehaviour 
{

	void OnCollisionEnter2D(Collision2D _col)
	{
		if (_col.collider.tag == "Wall") 
		{
			
			this.gameObject.transform.SetParent (_col.gameObject.transform);
		}
	}
}
