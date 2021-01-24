using System;
using System.Collections.Generic;

namespace CS133PROJECT5
{
    class Program
    {
        static void Main(string[] args)
        {
            Track myTrack = new Track();

            myTrack.AddInstruction("Your History");
            myTrack.AddInstruction("Click to go back, hold to see hystory");
            myTrack.AddInstruction("Click to go forward, hold to see hystory");
            myTrack.AddInstruction("Reload this page");

            myTrack.PrintInstruction();

            myTrack.UndoInstruction();

            myTrack.PrintRedoInstruction();

            myTrack.RedoInstruction();

            myTrack.PrintInstruction();
        }
    }
}

public class Track
{
    private Stack<string> instrutionsStack = new Stack<string>();

    private Stack<string> undoInstructionStack = new Stack<string>();

    public void AddInstruction(string newInstruction)
    {
        instrutionsStack.Push(newInstruction);
    }

    public void PrintInstruction()
    {
        foreach(var item in instrutionsStack)
        {
            Console.WriteLine("The instruction is the following: "
                              + item);
        }
    }

    public void UndoInstruction()
    {
       string firstInstruction = instrutionsStack.Pop();

        undoInstructionStack.Push(firstInstruction);
    }

    public void PrintRedoInstruction()
    {
        foreach (var item in undoInstructionStack)
        {
            Console.WriteLine("The instruction is the following: "
                              + item);
        }
    }

    public void RedoInstruction()
    {
        string firstInstruction = undoInstructionStack.Pop();

        undoInstructionStack.Push(firstInstruction);
    }
}