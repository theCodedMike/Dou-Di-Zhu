using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done_GradeCompare : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static bool Compare (int prevCardCount, GameObject[]prevObj,int cardCount, GameObject[]obj){
		if (GameObject.Find ("chupai").GetComponent<Done_Deal> ().xianShou == true) {return true;}
		if(Done_Rule.GameRule( cardCount,obj)==Done_Rule.CardType.wangZha){return true;}

		if (Done_Rule.GameRule (prevCardCount, prevObj) == Done_Rule.GameRule (cardCount, obj)) {
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.danPai) {
				if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.duiZi) {
				if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.sanBuDai) {
				if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.sanDaiYi) {
				if (obj [1].GetComponent<Done_Card> ().grade > prevObj [1].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.sanDaiYiDui) {
				if (obj [2].GetComponent<Done_Card> ().grade > prevObj [2].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.zhaDan) {
				if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.shunZi) {
				if (prevCardCount == cardCount) {
					if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
				}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.lianDui) {
				if (prevCardCount == cardCount) {
					if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {
						return true;
					}
				}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.feiJiDai) {
				if (prevCardCount == cardCount) {
					int m = cardCount / 4;
					int grade = 0,prevgrade=0;
					for (int i = 0; i <= m; i++) {
						int grade1 = obj [i].GetComponent<Done_Card> ().grade;
						int grade2 = obj [i + 1].GetComponent<Done_Card> ().grade;
						int grade3 = obj [i + 2].GetComponent<Done_Card> ().grade;
						if (grade1 == grade2 && grade1 == grade3) {
							grade = grade1;
							i = m + 1;
						}
					}
					for (int i = 0; i <= m; i++) {
						int grade1 = prevObj [i].GetComponent<Done_Card> ().grade;
						int grade2 = prevObj [i + 1].GetComponent<Done_Card> ().grade;
						int grade3 = prevObj [i + 2].GetComponent<Done_Card> ().grade;
						if (grade1 == grade2 && grade1 == grade3) {
							prevgrade = grade1;
							i = m + 1;
						}
					}
					if (grade >prevgrade) {return true;}
				}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.feiJiBuDai) {
				if (prevCardCount == cardCount) {
					if (obj [0].GetComponent<Done_Card> ().grade > prevObj [0].GetComponent<Done_Card> ().grade) {return true;}
				}
			}
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.siDaiEr) {
				if (obj [2].GetComponent<Done_Card> ().grade > prevObj [2].GetComponent<Done_Card> ().grade) {return true;}
			}
		}
		else {
			if (Done_Rule.GameRule (cardCount, obj) == Done_Rule.CardType.zhaDan && Done_Rule.GameRule (prevCardCount, prevObj)!=Done_Rule.CardType.wangZha) {return true;}
		}
		return false;
	}
}
