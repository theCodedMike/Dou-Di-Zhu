using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Done_Rule : MonoBehaviour {
	public enum CardType {  
		danPai,
		duiZi,
		wangZha,
		sanBuDai,
		sanDaiYi,
		sanDaiYiDui,
		zhaDan,
		shunZi,
		lianDui,
		feiJiDai,
		feiJiBuDai,
		siDaiEr,
		wrong
	} 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public static CardType GameRule (int cardCount, GameObject[]obj)
	{
		CardType cardType=CardType.wrong ; 
	

		if (cardCount == 1) {
			cardType = CardType.danPai;

		}
		if (cardCount == 2) {
			if (obj [0].GetComponent<Done_Card> ().grade == obj [1].GetComponent<Done_Card> ().grade) {
				cardType = CardType.duiZi;
			}
			if (obj [0].GetComponent<Done_Card> ().grade + obj [1].GetComponent<Done_Card> ().grade == 33) {
				cardType = CardType.wangZha;
			}
		}
		if (cardCount == 3) {
			int grade1 = obj [0].GetComponent<Done_Card> ().grade;
			int grade2 = obj [1].GetComponent<Done_Card> ().grade;
			int grade3 = obj [2].GetComponent<Done_Card> ().grade;
			if (grade1 == grade2 && grade1 == grade3) {
				cardType = CardType.sanBuDai;
			}
		}
	
		if (cardCount == 4) {
			int grade1 = obj [0].GetComponent<Done_Card> ().grade;
			int grade2 = obj [1].GetComponent<Done_Card> ().grade;
			int grade3 = obj [2].GetComponent<Done_Card> ().grade;
			int grade4 = obj [3].GetComponent<Done_Card> ().grade;
			if (grade1 == grade2 && grade1 == grade3 && grade1 == grade4) {
				cardType = CardType.zhaDan;

			} else if (grade1 == grade2 && grade1 == grade3) {
				cardType = CardType.sanDaiYi;
		
			} else if (grade2 == grade3 && grade2 == grade4) {
				cardType =CardType.sanDaiYi;

			}
		}

		if (cardCount == 5) {
			int grade1 = obj [0].GetComponent<Done_Card> ().grade;
			int grade2 = obj [1].GetComponent<Done_Card> ().grade;
			int grade3 = obj [2].GetComponent<Done_Card> ().grade;
			int grade4 = obj [3].GetComponent<Done_Card> ().grade;
			int grade5= obj [4].GetComponent<Done_Card> ().grade;
			if (grade1 == grade2 && grade3 == grade4 && grade4 == grade5) {
				cardType =CardType.sanDaiYiDui;
			}
			if (grade1 == grade2 && grade2 == grade3 && grade4 == grade5) {
				cardType =CardType.sanDaiYiDui;
			}

		}

		if (cardCount >= 5 && cardCount <= 12) {
			bool flag1 = true;
			for (int n = 0; n < cardCount - 1; n++) {
				int prew = obj [n].GetComponent<Done_Card> ().grade;
				int next = obj [n + 1].GetComponent<Done_Card> ().grade;
				if (prew == 17 || prew == 16 || prew == 15 || next == 17 || next == 16 || next == 15) {
					flag1 = false;
				} else {
					if (prew - next != -1) {
						flag1 = false;
					}
				}
			}
			if(flag1){cardType = CardType.shunZi;}

		}




		if (cardCount >= 6 && cardCount % 2 == 0) {
			bool flag2 = true;
			for (int n = 0; n < cardCount; n = n + 2) {
				if (obj [n].GetComponent<Done_Card> ().grade != obj [n + 1].GetComponent<Done_Card> ().grade) {
					flag2 = false;
				}
				if (n < cardCount - 2) {
					if (obj [n].GetComponent<Done_Card> ().grade - obj [n + 2].GetComponent<Done_Card> ().grade != -1) {
						flag2 = false;
					}
				}
			}
			if (flag2) {cardType = CardType.lianDui;}

		}
		 

			  
		if (cardCount >= 6 &&cardCount % 3 == 0) {  
			bool flag3 = true;

				int n = cardCount / 3;
				int[] grades=new int[n];
				for (int i = 0; i < n; i=i+3) {
					int grade1 = obj [i].GetComponent<Done_Card> ().grade;
					int grade2 = obj [i+1].GetComponent<Done_Card> ().grade;
					int grade3 = obj [i+2].GetComponent<Done_Card> ().grade;
					if (grade1 != grade2 || grade1 != grade3) {flag3 = false;}
					if (grade1 ==15) {flag3 = false;}
					if(i<cardCount -3){
						if (obj [i].GetComponent<Done_Card> ().grade - obj [i+ 3].GetComponent<Done_Card> ().grade != -1) {flag3 = false;}
					}
				}
			if (flag3) {cardType = CardType.feiJiBuDai;}
		} 

		if (cardCount >= 8 && cardCount % 4 == 0) {  
			bool flag4 = true;
			int m = cardCount / 4;
				int n = 100;
			for (int i = 0; i <= m; i++) {
				int grade1 = obj [i].GetComponent<Done_Card> ().grade;
				int grade2 = obj [i + 1].GetComponent<Done_Card> ().grade;
				int grade3 = obj [i + 2].GetComponent<Done_Card> ().grade;
				if (grade1 == grade2 && grade1 == grade3) {n=i;i = m + 1;}
				if (n != 100) {
					for(int j=0;j<m;j++){
						int grade4 = obj [n+j*3].GetComponent<Done_Card> ().grade;
						int grade5 = obj [n + 1+j*3].GetComponent<Done_Card> ().grade;
						int grade6 = obj [n + 2+j*3].GetComponent<Done_Card> ().grade;
						if (grade4 != grade5 || grade4!= grade6) {flag4 = false;}
						if (j < m - 1) {
							if (obj [n + 2 + j * 3].GetComponent<Done_Card> ().grade - obj [n + 3 + j * 3].GetComponent<Done_Card> ().grade != -1) {
								flag4 = false;
							}
						}
					}
				}
		    }
			if (n == 100) {flag4 = false;}
			if (flag4) {cardType = CardType.feiJiDai;}
	   	} 

		if (cardCount == 6 ) {

			for (int i = 0; i <= 2; i++) {
				int grade1 = obj [i].GetComponent<Done_Card> ().grade;
				int grade2 = obj [i + 1].GetComponent<Done_Card> ().grade;
				int grade3 = obj [i + 2].GetComponent<Done_Card> ().grade;
				int grade4 = obj [i + 3].GetComponent<Done_Card> ().grade;
				if (grade1 == grade2 && grade1 == grade3 && grade1 == grade4) {
					cardType = CardType.siDaiEr;
				}
			}

		}
		 
		return cardType;







	}
}
