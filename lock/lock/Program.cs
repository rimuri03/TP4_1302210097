﻿using System;

class DoorMachine
{
    private State currentState;

    public DoorMachine()
    {
        currentState = new LockedState();
    }

    public void SetState(State state)
    {
        currentState = state;
        currentState.DisplayState();
    }
}

interface State
{
    void DisplayState();
}

class LockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu terkunci");
    }
}

class UnlockedState : State
{
    public void DisplayState()
    {
        Console.WriteLine("Pintu tidak terkunci");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoorMachine doorMachine = new DoorMachine();

        // Mengubah state menjadi UnlockedState
        doorMachine.SetState(new UnlockedState());

        // Mengubah state menjadi LockedState
        doorMachine.SetState(new LockedState());
    }
}