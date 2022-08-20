using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengeHackerRank
{
    public class NotesStore
    {
        public Dictionary<string, string> Notes { get; set; }

        public NotesStore()
        {
            Notes = new Dictionary<string, string>();
        }

        public void AddNote(String state, String name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name cannot empty");

            ValidState(state);
            Notes.Add(name, state);
        }

        public List<String> GetNotes(String state)
        {
            ValidState(state);
            var filter = new List<string>();
            if (Notes.ContainsValue(state))
            {
                foreach (String key in Notes.Keys)
                {
                    if (Notes[key].Equals(state))
                        filter.Add(key);
                }
            }

            return filter;

        }

        private void ValidState(string state)
        {
            if (state != "completed" && state != "active" && state != "others")
                throw new Exception($"Invalid state { state }");

        }

    }

    public static class NerdStoreSolution
    {
        public static void Initial(string[] args)
        {
            var notesStoreObj = new NotesStore();
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var operationInfo = Console.ReadLine().Split(' ');
                try
                {
                    if (operationInfo[0] == "AddNote")
                        notesStoreObj.AddNote(operationInfo[1], operationInfo.Length == 2 ? "" : operationInfo[2]);
                    else if (operationInfo[0] == "GetNotes")
                    {
                        var result = notesStoreObj.GetNotes(operationInfo[1]);
                        if (result.Count == 0)
                            Console.WriteLine("No Notes");
                        else
                            Console.WriteLine(string.Join(",", result));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Parameter");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }
    }
}
