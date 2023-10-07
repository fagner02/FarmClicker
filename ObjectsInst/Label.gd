extends HBoxContainer


@export var text: String
@export var fruitName : String
@onready var res = load("res://Storage.tres")

# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if not SL.check(name):
		print("delete ", name)
		self.queue_free()
	$Label.text = text
	
func _gui_input(event):
	if event is InputEventMouseButton and event.pressed:
		print("button")
	
	if event is InputEventMouseButton and not event.pressed:
		print("not button")
