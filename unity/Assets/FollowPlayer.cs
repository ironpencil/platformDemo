using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
		//this.transform.position = player.position;
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 normalDistance = (this.transform.position - player.transform.position).normalized;

		float distanceX = Mathf.Abs(normalDistance.x);
		float distanceY = Mathf.Abs(normalDistance.y);

		float newPositionX = Mathf.Lerp (this.transform.position.x, player.position.x, distanceX);
		float newPositionY = Mathf.Lerp (this.transform.position.y, player.position.y, distanceY);

//		float newPositionX = Mathf.Lerp (this.transform.position.x, player.position.x, Time.deltaTime * 2f * distanceX);
//		float newPositionY = Mathf.Lerp (this.transform.position.y, player.position.y, Time.deltaTime * 2f * distanceY);

		this.transform.position = new Vector3(newPositionX, newPositionY, this.transform.position.z);

		//Vector3 newPosition = Vector3.Lerp(this.transform.position, player.transform.position, Time.deltaTime * 2f);
		//this.transform.position = new Vector3(newPosition.x, newPosition.y, this.transform.position.z);
	
	}
}
