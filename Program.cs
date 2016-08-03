using System;
using System.Collections.Generic;


//namespace FirstConsoleProject
//{
//	class MainClass
//	{
//		public static void Main (string[] args)
//		{
//			Start:
//
//			int num01;
//			int num02;
//
//			Console.WriteLine ("Type a num1:");
//			num01=Convert.ToInt32(Console.ReadLine ());
//			Console.WriteLine ("Type a num2:");
//			num02=Convert.ToInt32(Console.ReadLine ());
//			Console.WriteLine (num01+"divided by"+ num02+"is equal to"+num01/num02);
//
//			//wait the user to press a key. Then make the empty space and start over.
//			Console.ReadKey();
//			Console.WriteLine ();
//			goto Start;//go to the start;

//			Start:
//
//			Random numberGenerator = new Random ();
//
//			int num01 = numberGenerator.Next(1,11);
//			int num02 = numberGenerator.Next(1,11);
//
//			Console.WriteLine ("What is " + num01 + " times " + num02 + "?");
//
//			int answer = Convert.ToInt32 (Console.ReadLine ());
//
//			if (answer == num01 * num02) {
//
//				Console.WriteLine ("Well done! Your answer is correct.");
//
//			} else {
//
//				int responeseIndex = numberGenerator.Next (1, 4);
//
//				switch (responeseIndex) {
//
//				case 1: 
//					Console.WriteLine ("Are you even trying?");
//					break;
//				
//				case 2:
//					Console.WriteLine ("The answer is incorrect.");
//					break;
//
//				default:
//					Console.WriteLine ("You can do better than that.");
//					break;
//				}
//
//			}
//
//			Console.ReadKey();
//			goto Start;

//			for (int i = 1; i <=100; i++) {
//
//				if(i % 2 == 0) 
//				Console.Write(i+ ", ");		
//			    
//			}
//
//			Console.ReadKey();

//			int i = 1;
//
//			while (i <= 10) {			
//				Console.WriteLine(i);
//				i++;
//			}
//
//			Console.ReadKey();

//			Random numberGen = new Random ();
//
//			int numberOfAttempts = 0;
//			int attempt = 0;
//
//
//			while (attempt != 6) {
//  
//				attempt = numberGen.Next (1, 7);
//				Console.WriteLine ("Tom rolled:" + attempt + ".");
//				numberOfAttempts++;
//			}
//
//			Console.WriteLine ("It took Tom" + numberOfAttempts + " attempts to roll a six.");
//
//			Console.ReadKey();
//		}

//		public static void Main (string[]args)
//		{
//			int res=Add(10,8);
//
//			if(res>10)
//			Console.WriteLine("The result is larger than 10!");
//
//			else
//			Console.WriteLine("The result is smaller than 10!");
//
//			Console.ReadKey ();
//		}
//
//		public static int Add(int num01, int num02)
//		{
//		    
//			return num01 + num02;
//		}

//	    public static void Main (string[]args)
//		{
//			int[] numbers = new int[5];
//
//			numbers [0] = 12;
//			numbers [1] = 3;
//			numbers [2] = 5;
//				
//			for (int i = 0; i < numbers.Length; i++) {
//			
//				Console.Write (numbers [i]+",");
//			}
//
//			foreach (int number in numbers) {
//			
//				Console.Write (number + ",");
//			}

//			string[] names = new string[3] {
//				"Tom","Mark","Matt"
//			};

//			List<int> numbers = new List<int> ();
//
//			numbers.Add (13);
//			numbers.Add (4);
//			numbers.Add (8);
//
//			for (int i = 0; i < numbers.Count; i++) {
//			
//				Console.Write (numbers [i] + ",");
//			}
//
//			Console.WriteLine ();
//
//			numbers.RemoveAt(0);
//			numbers.Remove(4);
//
//			for (int i = 0; i < numbers.Count; i++) {
//			
//				Console.Write (numbers [i] + ",");
//			}
//
//			Console.ReadKey ();
//		}

//		public static void Main (string[]args)
//		{
//
//			CreateGrid();
//			Console.ReadKey ();
//		}
//		public static void CreateGrid()
//		{
//			int width = 20;
//			int height = 20;
//
//			int[,] grid = new int[width, height];
//
////			int[][]grid = new int[width][height];
////			grid [2][3] = 3;
//			grid [2, 3] = 3;
//
//			for (int x = 0; x < width; x++) {
//			
//				for (int y = 0; y < height; y++) {
//					grid [x, y] = x + y;
//					Console.Write (grid [x, y] + " ");	
////					grid[x][y]=x+y;
////					Console.Write (grid [x][y] + " ");
//				}
//
//				Console.WriteLine();
//			}
//
//		}
//
//	}
//}

//namespace FirstConsoleProject
//{
//
//	class Animal
//	{
//		public static int Count = 0;
//
//		public string name = "spotty";
//		public int age =6;
//		public float happiness = 0.5f;
//
//
//		public Animal()
//		{
//			name = "spotty";
//			age =6;
//			happiness = 0.5f;
//		
//			Count++;
//		}
//
//
//		public Animal(string _name, int _age, float _happiness)
//		{
//			name =_name ;
//			age =_age;
//			happiness =_happiness;
//
//			Count++;
//		}
//
//
//		public void Print()
//		{
//			Console.WriteLine ("Name:"+name);
//			Console.WriteLine ("Age:"+age);
//			Console.WriteLine ("Happiness:"+happiness);
//		}
//	}
//
//	//Inheriance:
//
////	class Dog: Animal
////	{
////
////		public int spotCount;
////
////		public void Bark()
////		{
////			Console.WriteLine ("WUF!");
////			base.happiness += 0.1f;//inheriance
////		}
////	}
////
////	class Cat: Animal
////	{
////
////		public float cuteness;
////
////		public void Meow()
////		{
////			Console.WriteLine ("MEOW!");
////		}
////	}
//
//
//	class MainClass
//	{
//		public static void Main (string[] args)
//		{
//			Animal dog = new Animal ();
//			dog.Print ();
//
//
//			Animal cat = new Animal ("Mr.Beans", 10,0.8f);
//			cat.Print ();
//
//			Console.WriteLine ();
//			Console.WriteLine ("Num of Animals:" + Animal.Count);
//
//
//			Console.ReadKey ();
//		}
//
//	}
//}

//namespace FirstConsoleProject
//{
//	class MainClass
//	{
//		enum Breed{Bulldog,Boxer,Chihuahua,Briard};
//
//		class Animal
//		{
//			public string name;
//			public int age;
//			public float happiness;
//		}
//
//
//
//		class Dog: Animal
//		{
//
//			public Breed breed;
//
//			public Dog(string _name,int _age,float _happiness, Breed _breed)
//			{
//				name=_name;
//				age=_age;
//				happiness=_happiness;
//
//				breed = _breed;
//			}
//
//			public void print()
//			{
//			
//				Console.WriteLine ("Name:" + name);
//				Console.WriteLine ("Age" + age);
//				Console.WriteLine ("Happiness:" + happiness);
//			
//				Console.WriteLine ("Breed:"+breed);
//			}
//		}
//
//		public static void Main (string[] args)
//		{
//			Dog hulk = new Dog ("Hulk", 6, 0.7f, Breed.Chihuahua);
//
//			hulk.print ();
//
//			Console.ReadKey ();
//		}
//
//	}
//}

//namespace FirstConsoleProject
//{
//	class MainClass
//	{
//
//		class Player
//		{
//			private int _health = 100;
//
//			public int health
//			{
//				get
//				{ 
//					return _health;
//				}
//
//				set
//				{ 
//					if (value <= 0) {
//						_health = 0;
//					} else if (value >= 100) {
//						_health = 100;
//					} else {
//						_health = value;
//					}
//				}
//			}
//
//			public void Damage (int _dmg)
//			{
//				_health -= _dmg;
//			}	
//		}
//			
//
//		public static void Main (string[] args)
//		{
//			Player tom = new Player ();
//
//			Console.WriteLine (tom.health);
//			tom.health -= 200;
//			Console.WriteLine (tom.health);
//			tom.health += 400;
//			Console.WriteLine (tom.health);
//			tom.health = 50;
//			Console.WriteLine (tom.health);
//
//			Console.ReadKey ();
//		}
//
//	}
//}


//namespace FirstConsoleProject
//{
//	class MainClass
//	{
//
//		interface IItem
//		{
//			string name { get;set;}
//			int goldValue{ get; set;}
//
//			void Equip();
//			void Sell();
//		}
//
//		interface IDamageable
//		{
//
//			int durability { get; set;}
//			void TakeDamage(int _amount);
//		}
//
//		interface IPartofQuest
//		{
//			void TurnIn();
//
//		}
//
//		class Sword : IItem, IDamageable,IPartofQuest
//		{
//			public string name{ get; set;}
//			public int goldValue{ get; set;}
//			public int durability { get; set;}
//
//			public Sword (string _name)
//			{
//				name=_name;
//				goldValue=100;
//			}
//
//			public void Equip()
//			{
//				Console.WriteLine (name + " equipped");
//			
//			}
//
//			public void Sell()
//			{
//				Console.WriteLine (name + " sold for" + goldValue + " imaginary dollars!");
//			}
//
//			public void TakeDamage (int _dmg)
//			{
//			
//				durability -= _dmg;
//				Console.WriteLine (name+ " damaged by" + _dmg +". It now has a durability of "+durability);
//			}
//
//			public void TurnIn()
//			{
//				Console.WriteLine (name + " turned in.");
//
//			}
//		}
//
//		class Axe: IItem, IDamageable,IPartofQuest
//		{
//			public string name{ get; set;}
//			public int goldValue{ get; set;}
//			public int durability { get; set;}
//
//			public Axe (string _name)
//			{
//				name=_name;
//				goldValue=70;
//				durability=50;
//			}
//
//			public void Equip()
//			{
//				Console.WriteLine (name + " equipped");
//
//			}
//
//			public void Sell()
//			{
//				Console.WriteLine (name + " sold for" + goldValue + " imaginary dollars!");
//			}
//
//			public void TakeDamage (int _dmg)
//			{
//
//				durability -= _dmg;
//				Console.WriteLine (name+ " damaged by" + _dmg + ". It now has a durability of "+durability);
//			}
//
//			public void TurnIn()
//			{
//				Console.WriteLine (name + " turned in.");
//
//			}
//		}
//
//		public static void Main (string[] args)
//		{
//			Sword sword = new Sword ("Swrod of Destiny");
//			sword.Equip ();
//			sword.TakeDamage (20);
//			sword.Sell ();
//			sword.TurnIn ();
//
//			Console.WriteLine ();
//
//			Axe axe = new Axe ("Fury Axe");
//			axe.Equip ();
//			axe.TakeDamage (10);
//			axe.Sell ();
//
//			Console.WriteLine ();
//
//			//create an inventory
//
//			IItem[] inventory = new IItem[2];
//			inventory [0] = sword;
//			inventory [1] = axe;
//
//			//Loop through and turn in all quest items
//
//			for (int i = 0; i < inventory.Length; i++) {
//			
//				IPartofQuest questitem = inventory [i] as IPartofQuest;
//				if (questitem != null) {
//					questitem.TurnIn ();
//				}
//			}
//
//			Console.ReadKey ();
//		}
//
//	}
//}




