using Command;

Console.Title = "Command";

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRepository();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(11, "Amine")));

commandManager.Undo();
repository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerList(repository, 1, new Employee(12, "Lin")));

commandManager.Invoke(new AddEmployeeToManagerList(repository, 2, new Employee(13, "Paul")));

repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();

Console.ReadKey();


