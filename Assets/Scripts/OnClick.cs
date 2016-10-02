using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OnClick : MonoBehaviour {

	[SerializeField]
	private Image imageinstrument;

	private Sprite[] instruments;
	void Start () 
	{
		instruments = Resources.LoadAll<Sprite> ("instrument");
		UpdateImage ();
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
	public void UpButton()
	{
		InstrumentSelect.imageSelect -= 1;
		UpdateImage ();
	}
	public void DownButton()
	{
		InstrumentSelect.imageSelect += 1;
		UpdateImage ();
	}

	void UpdateImage () 
	{
		if(InstrumentSelect.imageSelect > instruments.Length - 1)
		{
			InstrumentSelect.imageSelect = 0;
		}
		if(InstrumentSelect.imageSelect < 0)
		{
			InstrumentSelect.imageSelect = instruments.Length - 1;
		}
		imageinstrument.sprite = instruments [InstrumentSelect.imageSelect];
		/*if(imageselect == 1)
		{
			imageinstrument.sprite = Resources.Load<Sprite>("img1");
		}
		else if(imageselect == 2)
		{
			imageinstrument.sprite = Resources.Load<Sprite>("Claves");
		}
		else if(imageselect == 3)
		{
			imageinstrument.sprite = Resources.Load<Sprite>("guiro");
		}
		else if(imageselect == 0)
		{
			//imageinstrument.sprite = Resources.Load<Sprite>("img0");

		}*/
	}
}
