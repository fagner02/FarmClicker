extends Resource

class_name Data
var MainDict : Dictionary ={
	money = 0,
	#Add Ground
	#Add Chest
	#Add Money
}

var Grounds = {
	#Add Ground
}

var Ground ={
	id = 0,
	
}

var TreeDict ={
	treeType = "",
	Id = 0
}

var Box ={
	limit = 0
	#Add Fruit
}

var Fruit ={
	fruits = 0,
	fruitType = "",
	fruitPrice = 0,
	ftId = ""
}
var data = {}

var sto ={
	id = 0
}

func Check():
	var dataD = load("res://Data.tres") 
	print(data)
	for x in dataD.data.size():
		print(dataD.data.values()[x].id) 
	print(load("res://Data.tres"))
