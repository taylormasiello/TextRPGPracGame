﻿using System;
using System.Collections.Generic;
using static System.Console;
using static AdventureTextGame.TitleScreen;

namespace AdventureTextGame
{
    class Chapter2
    {
		int Scenarios = 1;

		static string[] sceneOne = {
			"Night begins to fall and you begin to shiver. You remember your cold-weather endurance training and press on.\nFatigue begins to hit you, and you wonder if you should continue, or rest for the night.\nYou look around, and see a cave in the distance. Who knows what could be lurking inside?\nHowever, it could provide the best shelter. Should you make camp in the cave? Or try your best making camp, more out in the open, but closer to the main road?\n(Please press A to investigate the cave or press B to make camp near the main road.)",
			"Ha! You almost laugh at your initial nervousness. You're an adventurer! No matter what lurks inside that cave,\nyou're brave and will be triumphant! You cautiously approach the cave, and as you do, you notice a shadow\nand prepare yourself for battle. As you draw closer, you realize, it's nothing more than a large mouse.",
			"The night air is cold, and your body is tired. No need to go all the way to a distant cave, only\nto be ambushed by some large beastie inside. Best to make camp close to the main road.",
			"You begin to make camp, and light a fire. Suddenly, you hear the rumbling of your stomach.\nWhen was the last time you ate?",
			"Licking your lips, you realize you'll have to vanquish this rodent, or fear you'll starve!\nAfter a bit of a chase, you catch and slay the large mouse. The meat smells good roasting on the fire.\nYou'll feel more refreshed and rested after a good night's sleep after this meal.",
			"You look around, but the area is bare. The field has nothing more than random insects. It's not the first\nnight you've gone to sleep without a meal, but you certainly wish you'd have grabbed some rations\nbefore heading out on your journey.",
			"You go to sleep, prepared to wake up well rested, ready to take on the next leg of your journey."
		};
		//static string[] sceneTwo = {
		//	"Description of story part two ... and the choice A or B",
		//	"... part two - what happens if A is chosen...",
		//	"... part two - what happens if B is chosen...",
		//	"....more story.... .",
		//	"... part two, again - what happens if A is chosen...",
		//	"... part two again - what happens if B is chosen...",
		//	"You begin to climb the stairs to the next floor...."
		//};
		//static string[] sceneThree = {
		//	"Description of story part three... and the choice A or B",
		//	"... part 3 - what happens if A is chosen...",
		//	"... part 3 - what happens if B is chosen...",
		//	"....more story.... .",
		//	"... part 3, again - what happens if A is chosen...",
		//	"... part 3 again - what happens if B is chosen...",
		//	"You begin to climb the stairs to the next floor...."
		//};


		public static void choice()
        {
			
			for (int scenario = 1; scenario <= 1; scenario++)
			{
				string input = "";

				switch (scenario)
				{
					case 1:
						//Part One
						//same pattern for each of the section; prints first part of the section
						WriteLine(sceneOne[0]);

						//2)read in player's choice (a or b)
						Console.ForegroundColor = ConsoleColor.Green;

						Write("Enter your choice: ");
						input = ReadLine();
						input = input.ToUpper();
						Console.ResetColor();

						//3) if A, print the next part of the array, otherwise skip next and print 3rd
						if (input == "A")
						{
							WriteLine(sceneOne[1]);

						}
						else
						{
							WriteLine(sceneOne[2]);
						}

						//4) print next part of the section
						WriteLine(sceneOne[3]);

						//5) if A, print next, otherwise skip ahead
						if (input == "A")
						{
							WriteLine(sceneOne[4]);
							Inventory.Add("roasted rodent dinner");

						}
						else
						{
							WriteLine(sceneOne[5]);
						}

						//6) print last piece of section
						WriteLine(sceneOne[6]);

						break;

					//case 2:
					//	//Part Two

					//	WriteLine(sceneTwo[0]);
					//	Console.ForegroundColor = ConsoleColor.Green;
					//	Write("Enter your choice: ");
					//	input = ReadLine();
					//	input = input.ToUpper();
					//	Console.ResetColor();
					//	if (input == "A")
					//	{
					//		WriteLine(sceneTwo[1]);

					//	}
					//	else
					//	{
					//		WriteLine(sceneTwo[2]);
					//	}
					//	WriteLine(sceneTwo[3]);
					//	if (input == "A")
					//	{
					//		WriteLine(sceneTwo[4]);

					//	}
					//	else
					//	{
					//		WriteLine(sceneTwo[5]);
					//	}
					//	WriteLine(sceneTwo[6]);

					//	break;

					//case 3:
					//	//Part Three
					//	WriteLine(sceneThree[0]);
					//	ForegroundColor = ConsoleColor.Green;
					//	Write("Enter your choice: ");
					//	input = ReadLine();
					//	input = input.ToUpper();
					//	Console.ResetColor();
					//	if (input == "A")
					//	{
					//		WriteLine(sceneThree[1]);

					//	}
					//	else
					//	{
					//		WriteLine(sceneThree[2]);
					//	}
					//	WriteLine(sceneThree[3]);
					//	if (input == "A")
					//	{
					//		WriteLine(sceneThree[4]);

					//	}
					//	else
					//	{
					//		WriteLine(sceneThree[5]);
					//	}
					//	WriteLine(sceneThree[6]);
					//	break;

					default:
						//default if section number does not match one of the above
						break;
				}

				//let player advance when ready, then clear the screen
				WriteLine("Press enter to continue...");
				ReadKey();
				Console.Clear();

			}
		}
    }
}