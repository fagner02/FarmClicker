extends Node2D


# Declare member variables here. Examples:
# var a = 2
# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	var a = ProjectSettings.get_setting("display/window/size/viewport_height")
	print_debug(a)
	position.y = (1920-a)/2


# Called every frame. 'delta' is the elapsed time since the previous frame.
#func _process(delta):
#	pass
