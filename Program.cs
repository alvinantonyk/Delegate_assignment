using Delegates_Assignment;


class Program
{

    public static bool Compare(Student S1, Student S2)
    {
        return S1.Score > S2.Score;
    }
    

    public static User InputUser()
    {
        User user = new User();

        Console.Write("Enter Id : ");
        user.Id = int.Parse(Console.ReadLine());
        Console.Write("Enter Name : ");
        user.Name = Console.ReadLine();
        Console.Write("Enter Contact : ");
        user.Contact = Console.ReadLine();
        Console.WriteLine("Enter Email : ");
        user.Email = Console.ReadLine();

        return user;


    }

    static void Main(string[] args)
    {


        List<Student> students = new List<Student> {

        new Student { Id = 100, Name = "Ram", Age = 15, Score = 99 },
        new Student { Id = 121, Name = "Arjun", Age = 19, Score = 89.8 },
        new Student { Id = 101, Name = "Rahul", Age = 15, Score = 99.9 },
        new Student { Id = 102, Name = "Riya", Age = 16, Score = 78.5 }
        };

        Console.WriteLine("before Sorting");
        foreach (Student student in students)
        {
            Console.WriteLine(student.Name+" "+student.Score);
        }
        Sort.BubbleSort(students, Compare);

        Console.WriteLine();
        Console.WriteLine("After Sorting");
        foreach (Student student in students)
        {
            Console.WriteLine(student.Name+" "+student.Score);
        }

        //User user1 = new User { Id = 1, Name = "John Doe", Email = "john@example.com", Contact = "1234567890" };
        //User user2 = new User { Id = 2, Name = "Jane Smith", Email = "jane@example.com", Contact = "9876543210" };
        //User user3 = new User { Id = 3, Name = "Alice Johnson", Email = "alice@example.com", Contact = "1112223333" };
        //User user4 = new User { Id = 4, Name = "Bob Brown", Email = "bob@example.com", Contact = "4445556666" };
        //User user5 = new User { Id = 5, Name = "Eva Lee", Email = "eva@example.com", Contact = "7778889999" };

       
        //service.AddUser(user1);
        //service.AddUser(user2);
        //service.AddUser(user3);
        //service.AddUser(user4);
        //service.AddUser(user5);


        UserService service = new UserService();

        do
        {
            Console.WriteLine();
            Console.WriteLine("Menu");
            Console.WriteLine("1.Add User");
            Console.WriteLine("2.Update User");
            Console.WriteLine("3.Delete User");
            Console.WriteLine("Choose 1-3");
            int a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    User user1 = InputUser();
                    service.AddUser(user1);
                    break;

            case 2:
                    User user2 = InputUser();
                    service.UpdateUser(user2);
                    break;

            case 3: Console.WriteLine("Enter id ");
                    int id = int.Parse(Console.ReadLine());
                    service.DeleteUser(id);
                    break;
            }
        } while (true);

    }
}





