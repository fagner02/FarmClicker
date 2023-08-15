
class_name JB

static func Print(var dict: Dictionary):
	var json : String = JSONBeautifier.beautify_json(JSON.print(dict), 4)
	return json
