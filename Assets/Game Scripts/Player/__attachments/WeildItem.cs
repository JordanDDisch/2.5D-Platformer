using UnityEngine;
using System.Collections;

public class WeildItem : MonoBehaviour {

	private bool [] itemInventory;
	public enum itemType
	{
		GrapplingHook = 0,
		JetPack = 1
	};
	private int currentItemIndex = 0;
	public int itemPreset = 0;
	public int itemTypeLength;
	// Use this for initialization
	void Start () {

		itemTypeLength = System.Enum.GetValues(typeof(itemType)).Length;
		itemInventory = new bool[itemTypeLength];
		itemInventory[(int)itemType.GrapplingHook] = true;
	}
	
	// Update is called once per frame
	void Update () {
		nextItem ();
		itemPresetChangedHandler ();
	}

	private void itemPresetChangedHandler()
	{
		switch(itemPreset)
		{
			case 1:
				print("Jet Pack");
				break;

			default:
				// itemtype.GrapplingHook
				print("Grappling Hook");
				break;
		}
	}

	private void nextItem() 
	{
		if(Input.GetKeyDown("tab")) 
		{
			if(itemPreset < itemTypeLength + 1) 
			{
				itemPreset ++;
			}
			if(itemPreset > 1)
			{
				itemPreset = 0;
			}
		}
	}
}


