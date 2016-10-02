using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InstrumentSelect : MonoBehaviour {
	public static int imageSelect;
	[SerializeField]
	private Text nameinstrument;
	[SerializeField]
	private Image imageinstrument;
	public AudioSource player;
	[SerializeField]
	private Slider sensitivity;
	private Sprite[] instruments;
	private AudioClip[] sounds;

	float lastX = 0;
	void Start () 
	{
		instruments = Resources.LoadAll<Sprite> ("instrument");
		sounds = Resources.LoadAll<AudioClip> ("sounds");
		imageinstrument.sprite = instruments [imageSelect];
		InvokeRepeating ("UpdateSound", .10f, .10f);
		Debug.Log (nameinstrument);
	}
	// Update is called once per frame
	void UpdateSound () {
		float x = (Mathf.Abs(Input.acceleration.x) + Mathf.Abs(Input.acceleration.z))/2f;
		if(x - lastX > 0.70f)
		{
			PlaySound ();
		}
		lastX = x;
		switch(imageSelect)
		{
		case 0:
			nameinstrument.text = "Pandeiro";
			break;
		case 1:
			nameinstrument.text = "Tambourine";
			break;
		case 2:
			nameinstrument.text = "Castanets";
			break;
		case 3:
			nameinstrument.text = "Claves";
			break;
		case 4:
			nameinstrument.text = "Guiro";
			break;
		case 5:
			nameinstrument.text = "WoodBlock";
			break;
		}

	}
	void PlaySound(){
		player.PlayOneShot (sounds [imageSelect]);
	}
}
