using MovieLibraryEntities.Context;
using MovieLibraryEntities.Dao;
using MovieLibraryEntities.Models;
using System;
using System.Collections.Generic;


namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{

    //private readonly IContext _context;
    private readonly IRepository _context;
    public MainService(IRepository repository)
    {
        _context = repository;
    }
    public void Invoke()
    {
        while (true)
        {
            Console.Write($"\nSearch the Database:\n\n1: Id\n2: Title\n3: List Movies\n4: Add Movie\n5: Modify Movie\n6: Delete Movie\n7: Add User\n8: List Users\nq: Exit\nEnter: ");
            var answer = Console.ReadLine();
            Console.WriteLine();

            if(answer == "1" ) 
            {
                _context.ReadById();
            }

            else if (answer == "2")
            {
                _context.ReadByTitle();
            }

            else if (answer == "3")
            {
                _context.ReturnAllMovies();
            }

            else if (answer == "4")
            {
                _context.AddMovie();
            }
            else if (answer == "5")
            {
                _context.ModifyMovie();
            }
            else if (answer == "6")
            {
                _context.DeleteMovie();
            }
            else if (answer == "7")
            {
                _context.AddUser();
            }
            else if (answer == "8")
            {
                _context.DisplayUsers();
            }
            else if (answer.ToLower() == "q")
            {
                Console.WriteLine("\nExiting the program...");
                break;
            }
            else
            {
                Console.WriteLine($"That is not a valid input\n");
            }      
        }
       
    }
}