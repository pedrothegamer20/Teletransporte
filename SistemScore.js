var score = 0;
var pickupscore = 0;
var ScoreText : UI.Text;


function Update () {
	ScoreText.text = score.ToString();
}

function OnTriggerEnter (other : Collider) {
	if (other.tag == "moneda"){
	Debug.Log("Moneda");
	score += pickupscore;
	Destroy(other.gameObject);
	}
	}
