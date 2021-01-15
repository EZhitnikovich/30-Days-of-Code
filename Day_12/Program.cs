using System;
using System.Linq;

class Person
{
	protected string firstName;
	protected string lastName;
	protected int id;

	public Person() { }
	public Person(string firstName, string lastName, int identification)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.id = identification;
	}
	public void printPerson()
	{
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
	}
}

class Student : Person
{

	private int[] testScores;

	/// <summary>
	/// Parameters: 
    ///   firstName - A string denoting the Person's first name.
    ///   lastName - A string denoting the Person's last name.
    ///   id - An integer denoting the Person's ID number.
    ///   scores - An array of integers denoting the Person's test scores.
	/// </summary>
	/// <param name="firstName"></param>
	/// <param name="lastName"></param>
	/// <param name="id"></param>
	/// <param name="scores"></param>
	public Student(string firstName, string lastName, int id, int[] scores): base(firstName, lastName, id)
    {
		testScores = scores;
	}

	/// <summary>
	/// </summary>
	/// <returns>
	/// A character denoting the grade.
	/// </returns>
	public char Calculate()
    {
		int avarage = testScores.Sum() / testScores.Count();

		char result = default(char);

		if(avarage >= 90 && avarage <= 100)
        {
			result = 'O';
        }
		else if(avarage >= 80 && avarage < 90)
        {
			result = 'E';
        }
		else if(avarage >= 70 && avarage < 80)
        {
			result = 'A';
        }
		else if(avarage >= 55 && avarage < 70)
        {
			result = 'P';
        }
		else if(avarage >= 40 && avarage < 55)
        {
			result = 'D';
        }
		else if(avarage >= 0 && avarage < 40)
        {
			result = 'T';
        }

		return result;
    }
}

class Solution
{
	static void Main()
	{
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
		string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
		int[] scores = new int[numScores];
		for (int i = 0; i < numScores; i++)
		{
			scores[i] = Convert.ToInt32(inputs[i]);
		}

		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}