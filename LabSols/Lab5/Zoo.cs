using System.Collections.Generic;
using System.Text;

namespace LabsSolutions.Lab5;

public class Zoo {
	Dictionary<string, int> animals = new Dictionary<string, int>();
	string[] originalAnimals = {"Zebra", "Lion", "Buffalo"};
	string[] newAnimals = {"Zebra", "Gazelle", "Buffalo", "Zebra"};
	
	public void Open(){
		foreach(string name in originalAnimals) {
			AddAnimal(name);
		}
		foreach(string name in newAnimals) {
			AddAnimal(name);
		}
	}
	
	private void AddAnimal(string name) {
		int count = 1;
		if(animals.ContainsKey(name)) {
			count = animals[name] + 1;
		}
		animals[name] = count;
	}

	public string ShowDetails() {
		StringBuilder sb = new StringBuilder();
		foreach(string name in animals.Keys) {
			sb.Append(name + ": " + animals[name] + "\n");
		}

		return sb.ToString();
	}

}
