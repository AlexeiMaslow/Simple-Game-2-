using UnityEngine;
using System.Collections;

public class MovingWalls : MonoBehaviour 
{
	[SerializeField] GameObject Wall_1;
	[SerializeField] GameObject Wall_2;
	public float speed;
	void Start()
	{
		StartCoroutine (MoveWall ());
	}

	IEnumerator MoveWall()
	{
		while (true) 
		{
			Wall_1.transform.localScale = new Vector3 (Wall_1.transform.localScale.x, Wall_1.transform.localScale.y + 0.1f, Wall_1.transform.localScale.z);
			Wall_2.transform.localScale = new Vector3 (Wall_2.transform.localScale.x, Wall_2.transform.localScale.y + 0.1f, Wall_2.transform.localScale.z);

			yield return new WaitForEndOfFrame ();
		}
	}
}
