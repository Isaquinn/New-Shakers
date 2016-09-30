using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {
	private int imageselect;
	private GameObject imageinstrument;
	// Use this for initialization
	void Start () {
		//imageselect = 0;
		imageinstrument = GameObject.Find("Canvas/Image");
	
	}
	// Update is called once per frame

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
	public void UpButton()
	{
		imageselect -= 1;
	}
	public void DownButton()
	{

		imageselect += 1;
		Debug.Log (imageselect);
	}
	void Update () 
	{
		if(imageselect == 1)
		{
			imageinstrument.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("1");
		}
		else if(imageselect == 2)
		{
			imageinstrument.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("Claves");
		}
		else if(imageselect == 3)
		{
			imageinstrument.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("guiro");
		}
		else if(imageselect == 0)
		{
			imageinstrument.gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>("0");

		}
		if(imageselect > 3)
		{
			imageselect = 0;
		}
		 if(imageselect < 0)
		{
			imageselect = 3;
		}
	}
}
