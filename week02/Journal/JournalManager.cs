public class JournalManager
{
    Journal _journal = new();
    public bool _isRunning = true;
    public string _fileName = string.Empty;
    PromptGenerator _generator = new();

    public void Run()
    {
        Console.WriteLine("Welcome to the journal Program!");
        while (_isRunning)
        {
            Console.WriteLine("Please select one of the following!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userChoice = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userChoice))
            {
                if (int.TryParse(userChoice, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            WriteEntry();
                            break;
                        case 2:
                            DisplayJournal();
                            break;
                        case 3:
                            LoadJournal();
                            break;
                        case 4:
                            WriteJournalToFile();
                            break;
                        case 5:
                            _isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Make sure to choose among given number.");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Please enter valid choice");
                }
            }
            else
            {
                Console.WriteLine("Please choose on the following!");
            }
        }
    }
    private void WriteEntry()
    {
        Entry entry = new();
        string promptText = _generator.GetRandomPrompt();
        Console.WriteLine(promptText);
        Console.Write("> ");
        string userResponse = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userResponse))
        {
            entry._promptText = promptText;
            entry._entryText = userResponse;
            _journal.AddEntry(entry);
        }
        else
        {
            Console.WriteLine("Please provide your response.");
        }

    }
    private void DisplayJournal()
    {
        _journal.DisplayAll();
    }
    private void LoadJournal()
    {
        while (true)
        {
            Console.Write("Please enter the name of the file: ");
            string filename = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(filename))
            {
                if (_fileName != filename)
                {
                    try
                    {
                         _journal.LoadFromFile(filename);
                    Console.WriteLine("Journal successfully loaded.");
                    _fileName = filename;
                    break;
                    }
                    catch (FileNotFoundException)
                    {
                        Console.WriteLine("There is not such file.");
                    }
                }
                else
                {
                    Console.WriteLine("You have already loaded the content of that filename.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("No filename provided");
            }
        }
    }
    private void WriteJournalToFile()
    {
        if (_journal._entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }
        Console.Write("Please provide the name of the file: ");
        string filename = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(filename))
        {
            _journal.SaveToFile(filename);
            Console.WriteLine("Journal successfully saved.");
        }
        else
        {
            Console.Write("filename is not provided.");
        }
    }
}