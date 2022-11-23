using System;
using System.Collections.Generic;
using System.Data;

namespace Chat_Logger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chat = new List<string>();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {

                string[] commandParams = command.Split(' ');

                string firstCommand = commandParams[0];

                if (firstCommand == "Chat")
                {
                    chat.Add(commandParams[1]);
                }
                else if (firstCommand == "Delete")
                {
                    if (chat.Contains(commandParams[2]))
                    {
                        chat.Remove(commandParams[2]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (firstCommand == "Edit")
                {   
                    if(chat.Contains(commandParams[1]))
                    {
                        
                        chat.Remove(commandParams[1]);
                        chat.Add(commandParams[2]);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (firstCommand == "Pin")
                {
                    if (chat.Contains(commandParams[1]))
                    {

                    }
                }
                else if (firstCommand == "Spam")
                {

                }
            }

            Console.WriteLine($" \n, {chat}");
        }
    }
}
