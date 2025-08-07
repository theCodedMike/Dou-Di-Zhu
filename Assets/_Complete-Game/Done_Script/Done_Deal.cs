using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done_Deal : MonoBehaviour {
    public Transform disCardPostion;
	public int passValue=2;
	public bool xianShou=true;
	public int layerLevel=1;

	public GameObject[] prevObj = new GameObject[20];
	public int prevCardCount= 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SortCards(int cardCount,GameObject []obj){
		for (int i = 0; i <cardCount; i++) {

			for (int j = 0; j < cardCount- i - 1; j++) {

				if (obj [j].GetComponent<Done_Card> ().grade > obj [j + 1].GetComponent<Done_Card> ().grade) {
					GameObject changes=obj[0];
					changes = obj [j];
					obj [j] = obj [j + 1];
					obj [j + 1] = changes;

				}
			}
		}

	}
	public void DisCard(){
		GameObject[] obj1 = new GameObject[20];
		int cardCount= 0;
		foreach(GameObject newobj in Done_AllCard.obj){
			if (newobj.GetComponent<Done_Card> ().isClick == false) {
				obj1 [cardCount] = newobj;
				cardCount++;
			}
		}
		SortCards(cardCount,obj1);
	
		if (Done_Rule.GameRule (cardCount, obj1)!=Done_Rule.CardType.wrong &&  Done_GradeCompare.Compare(prevCardCount,prevObj,cardCount,obj1) ==true   ) {
			Debug.Log (Done_Rule.GameRule (cardCount, obj1));
			layerLevel++;
			for (int i = 0; i < cardCount; i++) {
				obj1 [i].GetComponent<Done_Card> ().isClick = true;
			
				if (obj1 [i].transform.position.y-0.2f == GameObject.Find ("player1").transform.position.y) {
					GameObject.Find ("start").GetComponent<Done_AllCard> ().playerCount--;
				}
				if (obj1 [i].transform.position.y-0.2f == GameObject.Find ("computer1").transform.position.y) {
					GameObject.Find ("start").GetComponent<Done_AllCard> ().computer1Count--;
				}
				if (obj1 [i].transform.position.y-0.2f == GameObject.Find ("computer2").transform.position.y) {
					GameObject.Find ("start").GetComponent<Done_AllCard> ().computer2Count--;
				}
				obj1 [i].transform.position = disCardPostion.position + new Vector3 (i * 0.25f, 0, 0);
				obj1 [i].GetComponent<SpriteRenderer> ().sortingOrder= layerLevel;
				Debug.Log (obj1 [i]);
				prevObj[i]=obj1 [i];
			}
			prevCardCount= cardCount;
			passValue = 0;
			xianShou = false;
		}
	}
	public void Pass(){
	
		passValue++;
		if (passValue == 2) {
			xianShou = true;
		}
	}
}
