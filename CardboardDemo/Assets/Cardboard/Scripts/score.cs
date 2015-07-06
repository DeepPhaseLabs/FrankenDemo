using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {


public Text score;
private int score_count;


public void update_score(){

score_count +=1;
score.text="Points: " + score_count;

}
}