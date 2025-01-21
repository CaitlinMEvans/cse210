Class Design for Woodland Themed Mindfulness Program

1. Activity (Base Class)

Attributes:

- _name: stringThe name of the activity (e.g., "Breathing").
- _description: stringA brief explanation of the activity (e.g., "This activity will help you relax.").
- _animalGuide: stringThe woodland animal guide associated with the activity (e.g., "Deer").
- _duration: intThe duration of the activity in seconds.

Methods:

- SetDuration(int duration): voidSets the duration of the activity.
- DisplayStartingMessage(): voidDisplays the starting message, including the activity name, description, and animal guide.
- DisplayEndingMessage(): voidDisplays the ending message with the activity name and duration.
- ShowSpinner(int seconds): voidShows a spinner animation for a specified number of seconds.
- ShowCountdown(int seconds): voidDisplays a countdown timer.

2. BreathingActivity (Derived Class)

Attributes:
- None (inherits from Activity).

Methods:

- Run(ProgressTracker tracker): voidExecutes the breathing activity, guiding the user to alternate between breathing in and out for the specified duration.

3. ReflectingActivity (Derived Class)

Attributes:

- _prompts: ListA collection of prompts to encourage reflection (e.g., "Think of a time you showed courage.").
- _questions: ListA collection of follow-up questions to deepen the user's reflection (e.g., "Why was this meaningful to you?").

Methods:

- Run(ProgressTracker tracker): voidExecutes the reflection activity, displaying prompts and questions for the user to consider.
- GetRandomPrompt(): stringSelects a random prompt from the list of prompts.
- GetRandomQuestion(): stringSelects a random question from the list of questions.

4. ListingActivity (Derived Class)

Attributes:

- _prompts: ListA collection of prompts for the user to list responses (e.g., "List things you are grateful for.").

Methods:

- Run(ProgressTracker tracker): voidExecutes the listing activity, allowing the user to list items based on the prompt.
- GetRandomPrompt(): stringSelects a random prompt from the list of prompts.

5. ProgressTracker (Standalone Class)

Attributes:

- _completedActivities: ListA log of completed activities.
- _totalTime: intThe total time spent across all mindfulness activities.

Methods:

- LogActivity(string activityName, int duration): voidLogs a completed activity and its duration.
- DisplayProgress(): voidDisplays the completed activities and total mindfulness time.