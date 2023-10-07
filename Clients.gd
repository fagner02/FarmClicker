extends Node2D

signal collect
@onready var timer = get_node("Timer")
@export var time: int
var counter
var x

func _ready():
	timer.start(time)
	pass

func _on_Timer_timeout():
	emit_signal("collect")
	x = 1
	counter = timer.time_left*x
	print("time up")
	timer.start(time)
	pass # Replace with function body.
	
