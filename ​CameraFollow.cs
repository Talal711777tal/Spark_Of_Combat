void Update()

{

HandleTouchInput();

}

void HandleTouchInput()

{

if (Input.touchCount > 0)

{

Touch touch = Input.GetTouch(0);

if (touch.phase == TouchPhase.Began)

{

touchStartPosition = touch.position;

isTouching = true;

}

else if (touch.phase == TouchPhase.Moved || touch.phase == TouchPhase.Stationary)

{

touchCurrentPosition = touch.position;

Vector2 direction = (touchCurrentPosition - touchStartPosition).normalized;

if (playerController != null)

{

playerController.Move(direction)
