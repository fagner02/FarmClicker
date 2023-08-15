
class_name SL
const v = {"pressed": false}

static func WriteStorage():
	var res = load("res://Storage.tres")
	if res.loaded:
		var file = File.new()
		file.open("res://Storage.json", File.WRITE)
		file.store_line(JB.Print(res.main))
		file.close()
static func Save():
	var res = load("res://Storage.tres")
	var data = load("res://Data.tres")
	if res.loaded == true:
		if res.loading == false:
			res.loading = true
			var file = File.new()
			file.open("res://Datak.json", File.WRITE)
			file.store_line(JB.Print(data.MainDict))
			file.close()
			file.open("res://DataBackup.json", File.WRITE)
			file.store_line(JB.Print(data.MainDict))
			file.close()
			res.loading = false
	

static func Load():
	var res = load("res://Storage.tres")
	var data = load("res://Data.tres")
	var file := File.new()
	if file.file_exists("res://Datak.json"):
		file.open("res://Datak.json", File.READ)
		var jsn = file.get_as_text()
		if jsn != "":
			print("load")
			data.MainDict = JSON.parse(jsn).result
		else:
			print("correct")
			file.close()
			file.open("res://DataBackup.json", File.READ)
			jsn = file.get_as_text()
			data.MainDict = JSON.parse(jsn).result
	file.close()
	res.loaded = true
	return true

static func Check(id: float):
	var a = ceil(float(id)/float(2))
	var m = float(id)/float(2)
	var c = a-m
	var d : int
	if c>0:
		d = 1
	else:
		d=0
	return d
	
static func item(var name: String, var dict: Dictionary):
	return dict[name]
	pass
	
static func delete(var dict: Dictionary, dict1: Dictionary):
	#find(dict, "fruits", 0)
	for x in dict.size():
		if dict.values()[x-1].fruits == 0:
			for y in dict1.size():
				if dict1.values()[y-1] == dict.values()[x-1].ftId:
					dict1.erase(dict1.values()[y-1])
					return
			dict.erase(dict.values()[x-1].ftId)
			print("deleted")
	
static func check(name: String):
	var labels = load("res://Storage.tres").labels
	var exist = false
	for x in labels.size():
		if labels.values()[x] == name:
			exist = true
	return exist

static func find(dict: Dictionary, property: String, var test):
	var found = false
	var index
	var key 
	for x in dict.size():
		if test == dict.values()[x-1][property]:
			key = dict.keys()[x-1]
			found = true
			index = x-1
			return
	return key
	
static func getData():
	var storage = load("res://Storage.tres")
	
	if not storage.loaded:
		return
	else:
		print("els")
		var data = load("res://Data.tres")
		return data
	
