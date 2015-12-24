using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class FontChanger : MonoBehaviour {
	
	[SerializeField] Text textA;
	[SerializeField] Text textB;

	[SerializeField] Font[] fonts = new Font[5];

	int index = 0;

	void Start () {
		/*DirectoryInfo dir = new DirectoryInfo("Assets/Fonts/FontList");
		FileInfo[] info = dir.GetFiles("*.*");
		foreach (FileInfo f in info) {
			Font font = f;
		}*/

	}

	public void NextFont () {
		index = ++index < fonts.Length ? index : 0;
		textA.font = fonts [index];
		textB.font = textA.font;
	}
}
