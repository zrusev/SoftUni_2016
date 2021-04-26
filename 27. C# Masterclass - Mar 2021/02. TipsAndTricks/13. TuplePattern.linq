<Query Kind="Statements" />

// C# Masterclass. 02. C# Tips and Tricks
// Switch Expressions
// Tuple pattern

static string RockPaperScissors(string first, string second)
	=> (first, second) switch
	{
		("rock", "paper") => "rock is covered by paper. Paper wins.",
		("rock", "scissors") => "rock breaks scissors. Rock wins.",
		("paper", "rock") => "paper covers rock. Paper wins.",
		("paper", "scissors") => "paper is cut by scissors. Scissors wins.",
		("scissors", "rock") => "scissors is broken by rock. Rock wins.",
		("scissors", "paper") => "scissors cuts paper. Scissors wins.",
		(_, _) => "tie"
	};

RockPaperScissors("rock", "scissors").Dump();
RockPaperScissors("rock", "rock").Dump();
RockPaperScissors("paper", "scissors").Dump();
RockPaperScissors("rock", "paper").Dump();