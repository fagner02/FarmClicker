extends Area2D

signal click
onready var grass = load("res://ObjectsInst/Grass1.tscn")
var move: bool = false
var pos: Vector2
# Called when the node enters the scene tree for the first time.
func _ready():
	pos = get_parent().position
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


func _on_Button_input_event(viewport, event, shape_idx):
	if event is InputEventMouseButton and event.pressed:
		#print("jk")
		move = true
	if event is InputEventMouseButton and not event.pressed:
		move = false
		var temp =grass.instance()
		temp.visible = true
		temp.position = get_global_mouse_position()
		get_parent().get_parent().call_deferred('add_child', temp)
		get_parent().position = pos
		#print("out")
	pass # Replace with function body.
