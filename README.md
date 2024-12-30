# Dice Roll Guessing Game
![Screenshot 2024-12-30 145554](https://github.com/user-attachments/assets/6596d129-f8d3-4ad7-8739-108c55336875)
Description

The Dice Roll Guessing Game is a Windows Forms (or WPF) application where users can guess the value of a rolled 6-sided dice. The program tracks game statistics, including the number of times the user has played, their correct and incorrect guesses, and the frequency and percentage of each dice value rolled. Users can reset the game to its initial state at any time. The dice rolling animation simulates a realistic roll to enhance the user experience.

This project was created as part of a class assignment to demonstrate concepts such as input validation, animations, and statistical tracking in a Windows Forms or WPF application.
Features

    Dice Roll Simulation
        The dice image updates several times before settling on a random value to simulate rolling.
        Uses a for loop and Thread.Sleep() (Windows Forms) or Task.Delay() (WPF) for animation.
        Ensures randomness by generating a random number between 1 and 6 for each dice roll.

    User Input Validation
        Ensures that only valid values (1–6) can be entered in the guess textbox.
        Restricts input to a single digit by setting the MaxLength property of the textbox.
        Displays an error label for invalid input, preventing the dice from rolling until corrected.

    Game Statistics
        Tracks and displays:
            Number of games played.
            Number of correct and incorrect guesses.
            Frequency and percentage of each dice value rolled.
            Frequency of user guesses for each number.

    Reset Functionality
        A "Reset" button allows the user to restart the game, clearing all statistics and resetting the UI.

    XML Documentation
        All classes, attributes, and methods include XML comments for clear documentation.

    Meaningful UI Design
        All UI controls have meaningful names to enhance readability and maintainability of the code.

How to Use

    Enter a Guess:
        Input a single digit (1–6) into the guess textbox.
        If the input is invalid, an error label will prompt correction.

    Roll the Dice:
        Press the "Roll" button to simulate a dice roll.
        The dice image will animate, and the result will be displayed.
        The program will update game statistics and indicate whether the guess was correct or incorrect.

    View Statistics:
        The UI displays:
            Total games played.
            Number of correct and incorrect guesses.
            Frequency and percentage of each dice value rolled.
            Frequency of user guesses for each number.

    Reset the Game:
        Press the "Reset" button to clear all statistics and return the game to its initial state.

Requirements

    Environment: Windows Forms or WPF application
    Development Tools: Visual Studio (or equivalent)
    Languages and Frameworks: C# and .NET Framework (or .NET Core/5+ for WPF)

Error Handling

    Invalid inputs (non-numeric or out-of-range values) are highlighted with an error label next to the guess textbox.
    The dice roll is disabled until valid input is provided.

Common Issues Addressed

    Prevented program crashes by validating user input.
    Ensured the game does not proceed if invalid input is entered.
    Implemented a proper dice roll animation with random values for every step, not just the final result.
    Restricted input to a single digit in the guess textbox.
    Included XML comments for all class attributes and methods.
    Ensured meaningful names for all UI controls.

Future Improvements

    Add sound effects for dice rolls to enhance the user experience.
    Allow exporting game statistics to a file (e.g., CSV or text).
    Add graphical improvements, such as animations for winning or losing.
