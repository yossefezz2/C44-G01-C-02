using System;
namespace MyProject;


class Program
{
    static void Main(string[] args)
    {
        #region task 1
        //int Number1 = int.Parse(Console.ReadLine());

        //Console.WriteLine(Number1);
        #endregion

        #region task 2
        //string Text = "hello";
        //int Number2 = int.Parse(Text);
        //Console.WriteLine(Number2);
        // This will throw an exception because "hello" cannot be parsed to an integer.
        #endregion

        #region task 3
        //double doubleNumber = 15 / 7.6;
        //Console.WriteLine(doubleNumber);

        // If you use an integer repository, an error will occur when dealing with decimal values. Even in a case like 15 / 7, the result would be 2 instead of the correct value, because the integer type truncates the decimal part.

        // To fix this, we’ll replace it with a double to ensure accurate results with decimals.
        #endregion

        #region task 4
        //string text = "hello,world!";
        //string subtext = text.Substring(2, 7);

        //Console.WriteLine(text);
        //Console.WriteLine(subtext);
        #endregion

        #region task 5

        //string student1 = "ahmed";
        //string student2 = "mohamed";

        //Console.WriteLine(student1);
        //Console.WriteLine(student2);
        //// This will print the names of the students before any changes.

        //student2 = student1; // This will copy the value.

        //student1 = "ali";
        //// Changing the name of student1 will not affect student2 .
        //Console.WriteLine(student1);
        //Console.WriteLine(student2);

        #endregion
        #region task 6

        //student student1 = new student("ahmed",25);
        //student student2 = new student("mohamed", 30);

        //Console.WriteLine(student1.Name);
        //Console.WriteLine(student2.Name);

        //student2 = student1; // This will copy the reference, not the value.

        //student1.Name = "ali";
        //// Changing the name of student1 will also change the name of student2 because they reference the same object in memory.
        //Console.WriteLine(student1.Name);
        //Console.WriteLine(student2.Name);
        #endregion

        #region task 7
        //string subTex1t = "hello,";
        //string subText2 = "world!";

        //string AllText = subTex1t + subText2;

        //Console.WriteLine(AllText);
        #endregion

        #region task 8
        //b) A value 1 will be assigned to d.
        // This will print 1 because !(30 < 20) evaluates to true and Convert 1.
        #endregion

        #region task 9
        //d) 6 1
        #endregion

        #region task 10
        //d) 7 7
        #endregion
    }
}

class student
{
    public string Name;
    public int Age;
    public student(string name, int age)
    {
        Name = name;
        Age = age;
    }

}


