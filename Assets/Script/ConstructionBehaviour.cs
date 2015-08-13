using UnityEngine;
using System.Collections;

public class ConstructionBehaviour : MonoBehaviour {

	public int ConstructionType;
	public GameObject maisonHumain;
	public GameObject maisonZombie;
	public GameObject champ;
	private GameObject SwitchPrefab;

	void OnMouseDown()
	{
		switch (ConstructionType) {
		case 1:
			SwitchPrefab = maisonHumain;
			break;
		case 2:
			SwitchPrefab = champ;
			break;
		case 3:
			SwitchPrefab = maisonZombie;
			break;
		default:
			SwitchPrefab = maisonHumain;
			break;
		}
		switchPrefab ();
	}
	void switchPrefab()
	{
		Instantiate (SwitchPrefab, this.gameObject.transform.position, this.gameObject.transform.rotation);
		DestroyObject (this.gameObject);
	}
}
