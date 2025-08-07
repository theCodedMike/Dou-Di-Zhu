using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Done_AllCard : MonoBehaviour {
	
	public int[] cards=new int[54]{1,2,3,4,5,6,7,8,9,
		10,11,12,13,14,15,16,17,18,
		19,20,21,22,23,24,25,26,27,
		28,29,30,31,32,33,34,35,36,
		37,38,39,40,41,42,43,44,45,
		46,47,48,49,50,51,52,53,54};
	// Use this for initialization
	public static GameObject []obj=new GameObject[54];

	public Transform player1;
	public Transform computer1;
	public Transform computer2;

	public int playerCount=17;
	public int computer1Count=17;
	public int computer2Count=17;
	public string win;
	public GameObject winText;

	public Transform diZhuPai;
	public GameObject b1;
	public GameObject b2;
	public GameObject b3;
	public GameObject b4;
	public GameObject b5;
	public GameObject b6;
	public GameObject b7;
	public GameObject b8;
	public GameObject b9;
	public int count = 1;
	bool canDivide = true;
	public void CreateCard(string name,Transform player,int count,int i){
		GameObject gameObj=(GameObject)Instantiate (Resources.Load ("Done_Prefabs/"+name));
		gameObj.transform.position = player.position+new Vector3(count*0.25f,0,0);
		obj [i] = gameObj;
	}

	public void GetCard(int cardID,Transform player,int i){
		
	switch (cardID) {
		case 1:
			count++;
			CreateCard ("方块A", player, count,i);
			break;
		case 2:
			count++;
			CreateCard ("方块2", player, count,i);
			break;
		case 3:
			count++;
			CreateCard ("方块3", player, count,i);
			break;
		case 4:
			count++;
			CreateCard ("方块4", player, count,i);
			break;
		case 5:
			count++;
			CreateCard ("方块5", player, count,i);
			break;
		case 6:
			count++;
			CreateCard ("方块6", player, count,i);
			break;
		case 7:
			count++;
			CreateCard ("方块7", player, count,i);
			break;
		case 8:
			count++;
			CreateCard ("方块8", player, count,i);
			break;
		case 9:
			count++;
			CreateCard ("方块9", player, count,i);
			break;
		case 10:
			count++;
			CreateCard ("方块10", player, count,i);
			break;
		case 11:
			count++;
			CreateCard ("方块J", player, count,i);
			break;
		case 12:
			count++;
			CreateCard ("方块Q", player, count,i);
			break;
		case 13:
			count++;
			CreateCard ("方块K", player, count,i);
			break;
		case 14:
			count++;
			CreateCard ("梅花A", player, count,i);
			break;
		case 15:
			count++;
			CreateCard ("梅花2", player, count,i);
			break;
		case 16:
			count++;
			CreateCard ("梅花3", player, count,i);
			break;
		case 17:
			count++;
			CreateCard ("梅花4", player, count,i);
			break;
		case 18:
			count++;
			CreateCard ("梅花5", player, count,i);
			break;
		case 19:
			count++;
			CreateCard ("梅花6", player, count,i);
			break;
		case 20:
			count++;
			CreateCard ("梅花7", player, count,i);
			break;
		case 21:
			count++;
			CreateCard ("梅花8", player, count,i);
			break;
		case 22:
			count++;
			CreateCard ("梅花9", player, count,i);
			break;
		case 23:
			count++;
			CreateCard ("梅花10", player, count,i);
			break;
		case 24:
			count++;
			CreateCard ("梅花J", player, count,i);
			break;
		case 25:
			count++;
			CreateCard ("梅花Q", player, count,i);
			break;
		case 26:
			count++;
			CreateCard ("梅花K", player, count,i);
			break;
		case 27:
			count++;
			CreateCard ("红桃A", player, count,i);
			break;
		case 28:
			count++;
			CreateCard ("红桃2", player, count,i);
			break;
		case 29:
			count++;
			CreateCard ("红桃3", player, count,i);
			break;
		case 30:
			count++;
			CreateCard ("红桃4", player, count,i);
			break;
		case 31:
			count++;
			CreateCard ("红桃5", player, count,i);
			break;
		case 32:
			count++;
			CreateCard ("红桃6", player, count,i);
			break;
		case 33:
			count++;
			CreateCard ("红桃7", player, count,i);
			break;
		case 34:
			count++;
			CreateCard ("红桃8", player, count,i);
			break;
		case 35:
			count++;
			CreateCard ("红桃9", player, count,i);
			break;
		case 36:
			count++;
			CreateCard ("红桃10", player, count,i);
			break;
		case 37:
			count++;
			CreateCard ("红桃J", player, count,i);
			break;
		case 38:
			count++;
			CreateCard ("红桃Q", player, count,i);
			break;
		case 39:
			count++;
			CreateCard ("红桃K", player, count,i);
			break;
		case 40:
			count++;
			CreateCard ("黑桃A", player, count,i);
			break;
		case 41:
			count++;
			CreateCard ("黑桃2", player, count,i);
			break;
		case 42:
			count++;
			CreateCard ("黑桃3", player, count,i);
			break;
		case 43:
			count++;
			CreateCard ("黑桃4", player, count,i);
			break;
		case 44:
			count++;
			CreateCard ("黑桃5", player, count,i);
			break;
		case 45:
			count++;
			CreateCard ("黑桃6", player, count,i);
			break;
		case 46:
			count++;
			CreateCard ("黑桃7", player, count,i);
			break;
		case 47:
			count++;
			CreateCard ("黑桃8", player, count,i);
			break;
		case 48:
			count++;
			CreateCard ("黑桃9", player, count,i);
			break;
		case 49:
			count++;
			CreateCard ("黑桃10", player, count,i);
			break;
		case 50:
			count++;
			CreateCard ("黑桃J", player, count,i);
			break;
		case 51:
			count++;
			CreateCard ("黑桃Q", player, count,i);
			break;
		case 52:
			count++;
			CreateCard ("黑桃K", player, count,i);
			break;
		case 53:
			count++;
			CreateCard ("小王", player, count,i);
			break;
		case 54:
			count++;
			CreateCard ("大王", player, count,i);
			break;
		}
	
	
	}
	public void Shuffle(){
		for (int i = 0; i <= 100; i++) {
			int a,b,c;
			b = Random.Range (0, 54);
			c = Random.Range (0, 54);
			a = cards [b];
			cards [b] = cards [c];
			cards [c]=a;
		}
	
	}

	public void Divide(){
		
		for (int i = 1; i <= 17; i++) {
			int cardID= cards [i-1 ];
			GetCard (cardID, player1,i-1);

		}

		for (int i = 18; i <= 34; i++) {
			int cardID= cards [i - 1];
			GetCard (cardID,computer1,i-1);
		
		}
		for (int i = 35; i <= 51; i++) {
			int cardID= cards [i - 1];
			GetCard (cardID,computer2,i-1 );
		
		}
		for (int i = 52; i <= 54; i++) {
			int cardID= cards [i - 1];
			GetCard (cardID,diZhuPai,i-1 );

		}

	}
	public void SortCards(int size){
		for (int i = 0; i <17 ; i++) {
			
			for (int j = size-17; j < size- i - 1; j++) {
				Debug.Log (obj [j].GetComponent<Done_Card> ().grade);
				if (obj [j].GetComponent<Done_Card> ().grade > obj [j + 1].GetComponent<Done_Card> ().grade) {

					GameObject changes=obj[0];
					changes = obj [j];
					obj [j] = obj [j + 1];
					obj [j].transform.localPosition= obj [j].transform.localPosition-new Vector3(0.25f,0,0);
					obj [j + 1] = changes;
					obj [j+1].transform.localPosition=obj [j+1].transform.localPosition+ new Vector3(0.25f,0,0);

				}
			}
		}
			
	}
	public void JiaoDiZhu(){
		switch (Random.Range (0, 3)) {
		case 0:
			b1.SetActive (true);
			b3.SetActive (true);
			break;
		case 1:
			b4.SetActive (true);
			b6.SetActive (true);
			break;
		case 2:
			b7.SetActive (true);
			b9.SetActive (true);
			break;
		}
	}
	int gamePlayer1=1;
	int gamePlayer2=1;
	int gamePlayer3=1;
	int trun=0;

	public void Button1(){
		gamePlayer1++;
		trun++;
		b1.SetActive (false);
		b3.SetActive (false);
		b5.SetActive (true);
		b6.SetActive (true);
	
	
	}
	public void Button2(){
		gamePlayer1++;
		trun++;
		b2.SetActive (false);
		b3.SetActive (false);
		if (trun<3) {
			b5.SetActive (true);
			b6.SetActive (true);
		} 
		else {
			obj [51].transform.position = player1.transform.position + new Vector3 (19 * 0.25f, 0, 0);
			obj [52].transform.position = player1.transform.position + new Vector3 (20 * 0.25f, 0, 0);
			obj [53].transform.position = player1.transform.position + new Vector3 (21 * 0.25f, 0, 0);
			playerCount = playerCount+3;

		}
	}
	public void Button3(){
		gamePlayer1--;
		trun++;

		b1.SetActive (false);
		b2.SetActive (false);
		b3.SetActive (false);
		if (trun<3) {
				b5.SetActive (true);
				b6.SetActive (true);

		} else {
			if (gamePlayer2 == 2) {
				obj [51].transform.position = computer1.transform.position + new Vector3 (36 * 0.25f, 0, 0);
				obj [52].transform.position = computer1.transform.position + new Vector3 (37 * 0.25f, 0, 0);
				obj [53].transform.position = computer1.transform.position + new Vector3 (38 * 0.25f, 0, 0);
				computer1Count = computer1Count + 3;

			}
			if (gamePlayer3 == 2) {
				obj [51].transform.position = computer2.transform.position + new Vector3 (53 * 0.25f, 0, 0);
				obj [52].transform.position = computer2.transform.position + new Vector3 (54 * 0.25f, 0, 0);
				obj [53].transform.position = computer2.transform.position + new Vector3 (55 * 0.25f, 0, 0);
				computer2Count = computer2Count + 3;

			}
		}
	}
	public void Button4(){
		trun++;
		b4.SetActive (false);
		b6.SetActive (false);
		b8.SetActive (true);
		b9.SetActive (true);
		gamePlayer2 ++;

	}
	public void Button5(){
		gamePlayer2 ++;
		trun++;
		b5.SetActive (false);
		b6.SetActive (false);
		if (trun<3) {
			b8.SetActive (true);
			b9.SetActive (true);
		}
		else{
		    obj [51].transform.position = computer1.transform.position + new Vector3 (36 * 0.25f, 0, 0);
		    obj [52].transform.position = computer1.transform.position + new Vector3 (37 * 0.25f, 0, 0);
		    obj [53].transform.position = computer1.transform.position + new Vector3 (38 * 0.25f, 0, 0);
			computer1Count = computer1Count + 3;

	    }
	}
	public void Button6(){
		gamePlayer2--;
		trun++;
		b4.SetActive (false);
		b5.SetActive (false);
		b6.SetActive (false);
		if (trun<3) {
			b8.SetActive (true);
			b9.SetActive (true);
		}
		else {
			if (gamePlayer3 == 2) {
				obj [51].transform.position = computer2.transform.position + new Vector3 (53 * 0.25f, 0, 0);
				obj [52].transform.position = computer2.transform.position + new Vector3 (54 * 0.25f, 0, 0);
				obj [53].transform.position = computer2.transform.position + new Vector3 (55 * 0.25f, 0, 0);
				computer2Count = computer2Count + 3;

			}
			if (gamePlayer1 == 2) {
				obj [51].transform.position = player1.transform.position + new Vector3 (19 * 0.25f, 0, 0);
				obj [52].transform.position = player1.transform.position + new Vector3 (20 * 0.25f, 0, 0);
				obj [53].transform.position = player1.transform.position + new Vector3 (21 * 0.25f, 0, 0);
				playerCount = playerCount+3;
			}
		}
	}
	public void Button7(){
		trun++;
		b7.SetActive (false);
		b9.SetActive (false);
		b2.SetActive (true);
		b3.SetActive (true);
		gamePlayer3++;
	
	}
	public void Button8(){
		gamePlayer3++;
		trun++;
		b8.SetActive (false);
		b9.SetActive (false);
		if (trun<3) {
			b2.SetActive (true);
			b3.SetActive (true);
		}
		else{
			obj [51].transform.position = computer2.transform.position + new Vector3 (53 * 0.25f, 0, 0);
			obj [52].transform.position = computer2.transform.position + new Vector3 (54 * 0.25f, 0, 0);
			obj [53].transform.position = computer2.transform.position + new Vector3 (55 * 0.25f, 0, 0);
			computer2Count = computer2Count + 3;
		
		}
	}
	public void Button9(){
		gamePlayer3--;
		trun++;
		b7.SetActive (false);
		b8.SetActive (false);
		b9.SetActive (false);
		if (trun<3) {
			b2.SetActive (true);
			b3.SetActive (true);
		}
		else {
			if (gamePlayer1 == 2) {
				obj [51].transform.position = player1.transform.position + new Vector3 (19 * 0.25f, 0, 0);
				obj [52].transform.position = player1.transform.position + new Vector3 (20 * 0.25f, 0, 0);
				obj [53].transform.position = player1.transform.position + new Vector3 (21 * 0.25f, 0, 0);
				playerCount = playerCount+3;

			}
			if (gamePlayer2 == 2) {
				obj [51].transform.position = computer1.transform.position + new Vector3 (36 * 0.25f, 0, 0);
				obj [52].transform.position = computer1.transform.position + new Vector3 (37 * 0.25f, 0, 0);
				obj [53].transform.position = computer1.transform.position + new Vector3 (38 * 0.25f, 0, 0);
				computer1Count = computer1Count + 3;
			}
		}
	}
	public void GameStart(){

		Shuffle ();
		if (canDivide == true) {
			Divide ();
			canDivide = false;
			SortCards (17);
			SortCards (34);
			SortCards (51);
		
		}
		JiaoDiZhu ();
	}
	void Update(){
		
		if (playerCount == 0) {
			win = "玩家1方胜利";
		}
		if (computer1Count == 0) {
			win = "玩家2方胜利";
		} 
		if (computer2Count == 0) {
			win = "玩家3方胜利";
		}
		winText.GetComponent<UILabel>().text = win;
	}
}
