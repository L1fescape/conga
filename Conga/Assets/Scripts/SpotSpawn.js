#pragma strict

public var paintSpotPreFab: GameObject;

function Start () {

}

function getRandomRotation () : int {
  return (Random.value * 90) - 45;
}

function Update () {
  // Front wall
  if (Input.GetKeyDown(KeyCode.W)) {
    var frontPositionX = (Random.value * 10) - 5;
    var frontPositionY = (Random.value * 10);

    Instantiate(paintSpotPreFab, new Vector3(frontPositionX, frontPositionY, 4.99), Quaternion.Euler(getRandomRotation(), 90, -90));
  }

  // Left wall
  if (Input.GetKeyDown(KeyCode.A)) {
    var leftPositionY = (Random.value * 10);
    var leftPositionZ = (Random.value * 10) - 5;

    Instantiate(paintSpotPreFab, new Vector3(-4.99, leftPositionY, leftPositionZ), Quaternion.Euler(getRandomRotation(), 0, -90));
  }

  // Right wall
  if (Input.GetKeyDown(KeyCode.D)) {
    var rightPositionY = (Random.value * 10);
    var rightPositionZ = (Random.value * 10) - 5;

    Instantiate(paintSpotPreFab, new Vector3(4.99, rightPositionY, rightPositionZ), Quaternion.Euler(getRandomRotation(), 0, 90));
  }

  // Back wall
  if (Input.GetKeyDown(KeyCode.S)) {
    var backPositionX = (Random.value * 10) - 5;
    var backPositionY = (Random.value * 10);

    Instantiate(paintSpotPreFab, new Vector3(backPositionX, backPositionY, -4.99), Quaternion.Euler(getRandomRotation(), -90, -90));
  }
}