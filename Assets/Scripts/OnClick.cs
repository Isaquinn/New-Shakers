using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Play()
	{
		Application.LoadLevel ("select");
		Debug.Log ("Play");
	}
	public void SelectInstrument()
	{
		Application.LoadLevel ("app");
		Debug.Log ("App");
	}
	public void ChangeInstrument()
	{
		Application.LoadLevel ("select");
		Debug.Log ("Select");
	}
}
