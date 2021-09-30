using System;
using System.Collections.Generic;

namespace StateCodes
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //creating a dictionary using iterations of the class to add to collection
            var states = new List<State>() { 

                new State("OH", "Ohio"),
                new State("KY", "Kentucky"),
                new State("IN", "Indiana")
            
            };
            //creating a dictionary with class, added class state
            //var state1 = new State("OH", "Ohio");
            //states.Add(state1); //add instance of state to the list

            //var state2 = new State("KY", "Kentucky"); //don't do anything with the var except add to collection
            //states.Add(state2);

            ////can shorten statements
            //states.Add(new State("IN", "Indiana")); //create var/instance in the add statement w/o creating a var bc we don't need the vars

            ////iterate through list
            //foreach(var state in states) //if you want a property of the class instance, it is assigned to variable state
            //{
            //    Console.WriteLine($"For code {state.Code}, the state name is {state.Name}");
            //}





            //creating a dictionary
            //var statecodes = new Dictionary<string, string>() //<<need (); because it's a constructor unless using {}
            //{
            //    ["OH"] = "Ohio", ["IN"] = "Indiana", ["KY"] = "Kentucky"
            //};
            //can put in states individually OR ^^^
            //statecodes.Add("OH", "Ohio");
            //statecodes.Add("KY", "Kentucky");
            //statecodes.Add("IN", "Indiana");

            //var ohio = statecodes["OH"]; //this is how you typically access a dictionary
            //Console.WriteLine( ohio );


        }
    }
}
