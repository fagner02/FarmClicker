@tool
class_name CustomButton
extends Area2D

signal click#onready var grass = $Icon
var move: bool = false
# Called when the node enters the scene tree for the first time.
func _ready():
	pass # Replace with function body.

func _process(delta):
	if move:
		get_parent().position = get_global_mouse_position()

func _on_Area2D3_input_event(viewport, event, shape_idx):
	if event is InputEventMouseButton \
	and event.pressed:
		print("click")
		emit_signal("click")


func _on_Area2D_input_event(viewport, event, shape_idx):
	if event is InputEventMouseButton \
	and event.pressed:
		print("click")
		emit_signal("click")


func _on_CustomButton_input_event(viewport, event, shape_idx):
	
	pass # Replace with function body.
