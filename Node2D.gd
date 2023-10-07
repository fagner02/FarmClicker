extends Node2D


# Declare member variables here. Examples:
var a
@onready var res = load("res://Storage.tres")
@onready var data : Resource = load("res://Data.tres")


# var b = "text"


# Called when the node enters the scene tree for the first time.
func _ready():
	if !res.loaded:
		SL.Load()

func _physics_process(delta):
	
	pass
	
	
