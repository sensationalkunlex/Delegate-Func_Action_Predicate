// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");

Predicate<string> predicate = Action_Predicate_Func.PredicateCheck;

Console.WriteLine("Is it a number? Answer ={0}", predicate("738"));
Func<int, int, int> funcAddUp = Action_Predicate_Func.FuncAddup;

Console.WriteLine("Adding Up using Func= {0}", funcAddUp(738, 3644));

Action< int, int> actionAddingUp = Action_Predicate_Func.ActionAddup;
actionAddingUp(1, 1);
static class Action_Predicate_Func
{
    

    //Action has no return type (void)
   public static void ActionAddup(int x, int y)
    {
        Console.WriteLine("Action Adding up {0}", x + y);
    }

    //Predicate has a returntype always boolean
   public static bool PredicateCheck(string x) {

        return int.TryParse(x, out int result);
    }

    // Func with return turn
  public  static int FuncAddup(int x, int y)
    {
        return x + y;
    }

}