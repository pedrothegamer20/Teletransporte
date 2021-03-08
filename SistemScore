var PlayerScript : SistemScore;
var Precio : int;
var Display : GameObject;
var B1 : BoxCollider;
var B2 : BoxCollider;
var Pistol1 : GameObject;
var Pistol2 : GameObject;
var SinDinero : AudioSource;


function Start () {
	B1.enabled = true;
	B2.enabled = false;
	Pistol1.SetActive(true);
	Pistol2.SetActive(false);
}

function OnTriggerStay (other : Collider) {
	if(other.tag == "Player"){
	Display.GetComponent.<Text>().text = "K para comprar(500)";
	
	if (PlayerScript.score < Precio && Input.GetButtonDown("Accion")){
	SinDinero.Play();
	}
	}
	if (other.tag == "Player" && PlayerScript.score >= Precio && Input.GetButtonDown("Accion")){
	
		PlayerScript.score -= Precio;
		B1.enabled = false;
		B2.enabled = true;
		Pistol1.SetActive(false);
		Pistol2.SetActive(true);
		
		Display.GetComponent.<Text>().text = "K para comprar (500)";
		Destroy(this.gameObject);
		Destroy(Display.gameObject);
}
}


function OnTriggerExit (other : Collider) {

	if (other.tag == "Player"){
	Display.GetComponent.<Text>().text = "";
}
}
