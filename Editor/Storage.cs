using System;

namespace Editor
{
    class Storage
    {
        private string _data;

        public void Set()
        {
            do
            {
                Console.WriteLine("Enter a string or Press Enter to stop");
                string newData = Console.ReadLine();
                if (newData == String.Empty)
                { break; }
                else
                { _data = _data + "@delimiter" + newData; }

            } while (true);
        }

        public void Get()
        {
            while(_data!=String.Empty && _data!=null)
            {
                Console.WriteLine("Press Backspace key to see previously entered string");
                if (Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    int index = _data.LastIndexOf("@delimiter");
                    int length = _data.Length - (index + 10);
                    Console.WriteLine(_data.Substring((index+10),length));
                    _data = _data.Substring(0, index);
                }
            }
            Console.ReadLine();
        }
        
    }
}
