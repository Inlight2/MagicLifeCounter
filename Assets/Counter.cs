using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
	//there are two life totals because I show a version face up for both users
	[SerializeField] Text lifeTotalA;
	[SerializeField] Text lifeTotalB;

	void Start () {
		lifeTotalA.text = "20";
	}

	public void PlusButton () {
		int life = int.Parse (lifeTotalA.text);
		life ++;
		lifeTotalA.text = "" + life;
		lifeTotalB.text = lifeTotalA.text;
	}

	public void MinusButton () {
		int life = int.Parse (lifeTotalA.text);
		life--;
		lifeTotalA.text = "" + life;
		lifeTotalB.text = lifeTotalA.text;
	}

	public void Clear () {
		lifeTotalA.text = "20";
		lifeTotalB.text = "20";
	}
}
