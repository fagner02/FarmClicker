using System;
using System.Diagnostics;
using System.Text.Json;
using Godot;
using StorageManagement;

[GlobalClass]
public static class SLManage
{
    public static Data data;
    static bool loaded = false;
    public static void Load()
    {
        Godot.FileAccess file;

        if (Godot.FileAccess.FileExists("res://Data.json"))
        {
            try
            {
                file = Godot.FileAccess.Open("res://Data.json", Godot.FileAccess.ModeFlags.Read);
                var json = file.GetAsText();
                file.Close();
                var res = JsonSerializer.Deserialize<Data>(json) ?? throw new NullReferenceException();
                data = (Data)res;
            }
            catch
            {
                file = Godot.FileAccess.Open("res://DataBackup.json", Godot.FileAccess.ModeFlags.Read);
                var json = file.GetAsText();
                var res = JsonSerializer.Deserialize<Data>(json);
                data = (Data)res;
                file.Close();
            }
        }
        else
        {
            data = new Data();
            Save();
        }
    }

    public static void Save()
    {
        Godot.FileAccess file = Godot.FileAccess.Open("res://Data.json", Godot.FileAccess.ModeFlags.Write);
        var text = JsonSerializer.Serialize(data);
        Debugger.Log(0, null, text);
        file.StoreLine(text);
        file.Close();
        file = Godot.FileAccess.Open("res://DataBackup.json", Godot.FileAccess.ModeFlags.Write);
        file.StoreLine(JsonSerializer.Serialize(data));
        file.Close();
    }


    public static int Check(double id)
    {
        double a = Math.Ceiling(id / 2.0);
        double m = id / 2.0;
        double c = a - m;

        int d;
        if (c > 0)
            d = 1;
        else
            d = 0;

        return d;
    }



    public static void Delete()
    {

    }


}


// class_name SL
// const v = {"pressed": false}

// static func WriteStorage():
// 	var res = load("res://Storage.tres")
// 	if res.loaded:
// 		var file = File.new()

//         file.open("res://Storage.json", File.WRITE)

//         file.store_line(JB.Print(res.main))

//         file.close()





// static func item(name: String, dict: Dictionary):
// 	return dict[name]

//     pass

// static func delete(dict: Dictionary, dict1: Dictionary):
// 	#find(dict, "fruits", 0)
// 	for x in dict.size():

//         if dict.values()[x - 1].fruits == 0:
// 			for y in dict1.size():

//                 if dict1.values()[y - 1] == dict.values()[x - 1].ftId:
// 					dict1.erase(dict1.values()[y - 1])

//                     return
//             dict.erase(dict.values()[x - 1].ftId)

//             print("deleted")


// static func check(name: String):
// 	var labels = load("res://Storage.tres").labels
// 	var exist = false
// 	for x in labels.size():
// 		if labels.values()[x] == name:
// 			exist = true

//     return exist

// static func find(dict: Dictionary, property: String, test):
// 	var found = false
// 	var index
// 	var key 
// 	for x in dict.size():
// 		if test == dict.values()[x - 1][property]:
// 			key = dict.keys()[x - 1]

//             found = true

//             index = x - 1

//             return

//     return key


// static func getData():
// 	var storage = load("res://Storage.tres")

// 	if not storage.loaded:
// 		return

//     else:
// 		print("els")

//         var data = load("res://Data.tres")
// 		return data


