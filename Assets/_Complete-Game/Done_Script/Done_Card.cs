using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Done_Card : MonoBehaviour {
	// 牌的数字ID,1到54  
	public int id;  
	public CardBigType bigType;
	public CardSmallType smallType;
	public int grade; 
	public string imageName;

	public bool isClick=true;

	public enum CardBigType {  
		Spade,Heart, Club, Diamond, Red_Joker, Black_Joker  
	} 
	public enum CardSmallType {  
		A, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, J, Q, K,  Black_Joker, Red_Joker,
	}  

	/** 
  * 根据牌的id获得一张牌的大类型：方块，梅花,红桃,黑桃,小王,大王 * 
  *  牌的大类型：方块，梅花,红桃,黑桃,小王,大王 
  */  
	public static CardBigType GetBigType(int id) {  
		CardBigType bigType=CardBigType. Spade;  
		if (id >= 1 && id <= 13) {  
			bigType = CardBigType.Diamond;  
		} else if (id >= 14 && id <= 26) {  
			bigType = CardBigType.Club;  
		} else if (id >= 27 && id <= 39) {  
			bigType = CardBigType.Heart;  
		} else if (id >= 40 && id <= 52) {  
			bigType = CardBigType.Spade;  
		} else if (id == 53) {  
			bigType = CardBigType.Black_Joker;  
		} else if (id == 54) {  
			bigType = CardBigType.Red_Joker;  
		}  
		return bigType;  
	}  
	/** 
  * 根据牌的id，获取牌的小类型：2_10,A,J,Q,K 
  * 牌的小类型：2_10,A,J,Q,K 
  */  
	public static CardSmallType GetSmallType(int id) {  
		if (id < 1 || id > 54) {  
			
			  
		}  

		CardSmallType smallType=CardSmallType.A ;  

		if (id >= 1 && id <= 52) {  
			smallType = numToType(id % 13);  
		} else if (id == 53) {  
			smallType = CardSmallType.Black_Joker;  
		} else if (id == 54) {  
			smallType = CardSmallType.Red_Joker;  
		} else {  
			 
		}  
		return smallType;  
	}  

	/** 
  * 将阿拉伯数字0到12转换成对应的小牌型,被getSmallType方法调用 
  *牌的小类型 
  */  
	private static CardSmallType numToType(int num) {  
		CardSmallType type=CardSmallType.K ;  
		switch (num) {  
		case 0:  
			type = CardSmallType.K;  
			break;  
		case 1:  
			type = CardSmallType.A;  
			break;  
		case 2:  
			type = CardSmallType.Two;  
			break;  
		case 3:  
			type = CardSmallType.Three;  
			break;  
		case 4:  
			type = CardSmallType.Four;  
			break;  
		case 5:  
			type = CardSmallType.Five;  
			break;  
		case 6:  
			type = CardSmallType.Six;  
			break;  
		case 7:  
			type = CardSmallType.Seven;  
			break;  
		case 8:  
			type = CardSmallType.Eight;  
			break;  
		case 9:  
			type = CardSmallType.Nine;  
			break;  
		case 10:  
			type = CardSmallType.Ten;  
			break;  
		case 11:  
			type = CardSmallType.J;  
			break;  
		case 12:  
			type = CardSmallType.Q;  
			break;  

		}  
		return type;  
	}  
	/** 
  * 根据牌的id，获得一张牌的等级 
  *与牌数字对应的等级 
  */  
	public static int GetGrade(int id) {  

		if (id < 1 || id > 54) {  
			 
		}  

		int grade = 0;  

		// 2个王必须放在前边判断  
		if (id == 53) {  
			grade = 16;  
		} else if (id == 54) {  
			grade = 17;  
		}  

		else {  
			int modResult = id % 13;  

			if (modResult == 1) {  
				grade = 14;  
			} else if (modResult == 2) {  
				grade = 15;  
			} else if (modResult == 3) {  
				grade = 3;  
			} else if (modResult == 4) {  
				grade = 4;  
			} else if (modResult == 5) {  
				grade = 5;  
			} else if (modResult == 6) {  
				grade = 6;  
			} else if (modResult == 7) {  
				grade = 7;  
			} else if (modResult == 8) {  
				grade = 8;  
			} else if (modResult == 9) {  
				grade = 9;  
			} else if (modResult == 10) {  
				grade = 10;  
			} else if (modResult == 11) {  
				grade = 11;  
			} else if (modResult == 12) {  
				grade = 12;  
			} else if (modResult == 0) {  
				grade = 13;  
			}  

		}  

		return grade;  
	}  
	/** 
  * 根据牌的id获得牌图片的名字 
  *图片的名字 
  */  
	public static string GetImageName(int id) {  
		// 得到图片的前一个字符，表示是第几个牌  
		string imageName = "";  

		if (id == 53) {  
			imageName = "小王";  
		} else if (id == 54) {  
			imageName = "大王";  
		} else {  
			int mod = id % 13;  
			string firstLetter = "";  
			switch (mod) {  
			case 0:  
				firstLetter = "K";  
				break;  
			case 1:  
				firstLetter = "A";  
				break;  
			case 2:  
			case 3:  
			case 4:  
			case 5:  
			case 6:  
			case 7:  
			case 8:  
			case 9:  
			case 10:  
				firstLetter = "" + mod;  
				break;  
			case 11:  
				firstLetter = "J";  
				break;  
			case 12:  
				firstLetter = "Q";  
				break;  
			default:  
				break;  
			}  

			string secondLetter = "";  
			// 得到图片的后一个字符，表示什么颜色的牌  
			if (id >= 1 && id <= 13) {  
				secondLetter = "方块";  
			} else if (id >= 14 && id <= 26) {  
				secondLetter = "梅花";  
			} else if (id >= 27 && id <= 39) {  
				secondLetter = "红桃";  
			} else if (id >= 40 && id <= 52) {  
				secondLetter = "黑桃";  
			}  

			imageName = secondLetter+firstLetter  ;  
		}  
	 

		return imageName ;  
	} 


	public void OnMouseDown(){
		Debug.Log (gameObject.transform.position);
		if (isClick == true) {
			if (gameObject.transform.position.y != 2.8) {
				gameObject.transform.position = this.gameObject.transform.position + new Vector3 (0, 0.2f, 0);
				isClick = false;
			}
		} else {
			if (gameObject.transform.position.y != 2.8) {
				gameObject.transform.position = this.gameObject.transform.position + new Vector3 (0, -0.2f, 0);
				isClick = true;
			}

		}
	}
	void Start(){
		
		imageName = GetImageName (id);
		bigType=GetBigType (id);
		smallType=GetSmallType (id);
		grade = GetGrade (id);
		Debug.Log (imageName +"  "+ bigType+"  "+ smallType+"  "+ grade);
	}

	void Update(){
		

	}
}
