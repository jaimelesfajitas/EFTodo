Todo Bathroom = new Todo("Laver les toilettes", false);
Todo Kitchen = new Todo("vider le lave-vaisselle", true);
Todo Room = new Todo("Faire son lit", false);

TodoContext Db = new TodoContext();
// Db.Todo.AddRange(Bathroom, Kitchen, Room);
Db.SaveChanges(); // a tjr faire quand on modifie la bdd

// Console.WriteLine("----Liste de tous les todos----");
// string tacheNonFaite = "----Liste des todo non faites";
// for (int i = 0; i < Db.Todo.Count(); i++)
// {
//     Console.WriteLine($"Todo {Db.Todo.ToList()[i].Id}, tâche: {Db.Todo.ToList()[i].Task}, completed: {Db.Todo.ToList()[i].Completed}");
//     if (!Db.Todo.ToList()[i].Completed)
//     {
//         tacheNonFaite += $"\nTodo {Db.Todo.ToList()[i].Id}, tâche: {Db.Todo.ToList()[i].Task}, completed: {Db.Todo.ToList()[i].Completed}";
//     }
// }
// Console.WriteLine(tacheNonFaite);

for (int i = 0; i < Db.Todo.Count(); i++)
{
    if (!Db.Todo.ToList()[i].Completed)
    {
        Db.Todo.ToList()[i].Completed = true;
    }
    Console.WriteLine($"Todo {Db.Todo.ToList()[i].Id}, tâche: {Db.Todo.ToList()[i].Task}, completed: {Db.Todo.ToList()[i].Completed}");
}

Db.SaveChanges();
