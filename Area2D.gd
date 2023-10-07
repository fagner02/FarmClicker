extends Area2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"
@onready var res = load("res://Storage.tres")
@onready var te = get_node("../Background/Background/Label")
@onready var cam = get_node("../Camera2D")
@onready var ca = get_node("../UpperCanvas")
var c = false
var i : float
@export var screenSize : Vector2
var p : Vector2
var cc
# Called when the node enters the scene tree for the first time.
func _ready():
	
	screenSize = DisplayServer.screen_get_size()
	ProjectSettings.set_setting("display/window/size/viewport_height", screenSize.x)
	ProjectSettings.set_setting("display/window/size/viewport_width", screenSize.y)
	#ProjectSettings.set_setting("display/window/size/test_height", screenSize.x)
	#ProjectSettings.set_setting("display/window/size/test_width", screenSize.y)
	te.text = str(screenSize)
	#var ic = float(OS.get_screen_size().x)/float(OS.get_screen_size().y)
	#var cc = 2-ic/(float(1080)/float(2340))
	
# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	screenSize=(get_window().size)
	self.position = get_global_mouse_position()
	
func _input(event):
	var t	
	if event is InputEventMouseButton:
			pass

func _on_Area2D_body_entered(body):
	te.text = "uniomop,"
	if Input.is_mouse_button_pressed(1):
		print(DisplayServer.screen_get_size())
		
		body.get_parent().click = true
		

func _on_Area2D_body_exited(body):
	te.text = "no"



func _on_Area2D_input_event(viewport, event, shape_idx):
	if event is InputEventMouseButton and event.pressed:
		res.button_pressed = true
		print("pressed")
	if event is InputEventMouseButton and not event.pressed:
		res.button_pressed = false
		print("release")
