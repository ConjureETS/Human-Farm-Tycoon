using UnityEngine;
using System.Collections;

public class ConstructionBehaviour : MonoBehaviour {

	public int ConstructionType =-1 ;
	public GameObject maisonHumain;
	public GameObject maisonZombie;
	private GameObject SwitchPrefab;

	void OnMouseDown()
	{
		if (ConstructionType == -1)
			int.TryParse(Input.inputString, out ConstructionType);
		switch (ConstructionType) {
		case 1:
			SwitchPrefab = maisonHumain;
			break;
		case 2:
			SwitchPrefab = maisonZombie;
			break;
		default:
			SwitchPrefab = null;
			break;
		}
		switchPrefab ();
	}
	void switchPrefab()
	{
		if (SwitchPrefab != null) {
			Instantiate (SwitchPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
			DestroyObject (this.gameObject);
		}
	}
}
