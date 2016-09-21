using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovePlayer : MonoBehaviour
{
	public GameObject _Player;

	public void _Jump()
	{
		this.transform.SetParent (null);
		_Player.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 600),ForceMode2D.Impulse);
	}

}
