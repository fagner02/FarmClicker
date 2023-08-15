extends Area2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.


# Called every frame. 'delta' is the elapsed time since the previous frame.



func _on_Area2D_input_event(viewport, event, shape_idx):
	print("enrt")
	if Input.is_mouse_button_pressed(1):
		self.OnClick()
		
func OnClick():
	print("clik")


func _on_Area2D_mouse_entered():
	print("enrt")
	if Input.is_mouse_button_pressed(1):
		self.OnClick()
