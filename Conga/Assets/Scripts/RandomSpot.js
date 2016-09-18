#pragma strict

var rend: Renderer;

function Start () {
  rend = GetComponent.<Renderer>();

  // Change the color of the object randomly.
  var randomColor = new Color(Random.value, Random.value, Random.value, 1.0f);
  rend.material.color = randomColor;

  // Change the size of the object randomly.
  var randomScale = Random.value * 0.15;
  rend.transform.localScale += Vector3(randomScale, 0, randomScale);
}

function Update () {

}