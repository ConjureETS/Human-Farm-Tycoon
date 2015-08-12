using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WorkerToWoodController : MonoBehaviour{

    public Text nbWorker;
    public Text stats;
    /*public Text nbRessourceGet;
    public Text nbWorkerLeft;*/

    public void AddWorker()
    {
        stats.text = stats.text + "+1";
        UpdateView();
    }

    public void LessWorker()
    {
        stats.text = stats.text + "-1";
        UpdateView();
    }

    public void UpdateView()
    {
        nbWorker.text = stats.text;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
