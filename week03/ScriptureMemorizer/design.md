# W03 Scripture Memorizer Design - Teams 
Design for ScriptureMemorizer Questions:
=====================================
## What does the program do? 
The program helps users memorize scripture by displaying it fully and then progressively hiding random words in the text until the entire scripture is hidden.

## What user inputs does it have?
Users can press the Enter key to hide additional words or type quit to end the program.

## What output does it produce?
The program displays the scripture, starting fully visible and gradually replacing words with underscores (_). The number of underscores matches the number of characters in the hidden word.

## How does the program end?
The program ends when either:
The user types quit.
All words in the scripture have been hidden.


## Classes and Responsibilities

### 1. Scripture
**Responsibilities:**
- Store and manage the scripture reference and text.
- Track which words are hidden and which are visible.
- Provide methods to hide random words and get the displayable version of the scripture.
- Determine if the entire scripture is hidden.

**Attributes:**
- `_reference` : `Reference` (Represents the scripture reference.)
- `_words` : `List<Word>` (Stores each word of the scripture as a `Word` object.)

**Methods:**
- `HideRandomWords(numberToHide : int) : void`  
  Hides a specified number of random words in the scripture.
- `GetDisplayText() : string`  
  Returns the scripture text with hidden words replaced by underscores.
- `IsCompletelyHidden() : bool`  
  Returns true if all words in the scripture are hidden.

### 2. Reference
**Responsibilities:**
- Store and provide the scripture reference (book, chapter, and verse(s)).
- Support single and multi-verse references.

**Attributes:**
- `_book` : `string`  
  The book name (e.g., "Proverbs").
- `_chapter` : `int`  
  The chapter number.
- `_verse` : `int`  
  The starting verse number.
- `_endVerse` : `int`  
  The ending verse number (optional).

**Methods:**
- `GetDisplayText() : string`  
  Returns the full reference as a string (e.g., "Proverbs 3:5-6").

### 3. Word
**Responsibilities:**
- Represent a single word in the scripture.
- Track whether the word is hidden or visible.
- Provide its displayable text (either the word itself or underscores).

**Attributes:**
- `_text` : `string`  
  The actual word text.
- `_isHidden` : `bool`  
  Whether the word is currently hidden.

**Methods:**
- `Hide() : void`  
  Hides the word.
- `Show() : void`  
  Makes the word visible again.
- `IsHidden() : bool`  
  Returns true if the word is hidden.
- `GetDisplayText() : string`  
  Returns the word text or underscores based on its visibility.

---

## Behaviors and Interaction

### How the Program Works:
1. The `Scripture` class manages the scripture's text and reference and delegates word management to the `Word` class.
2. The `Reference` class handles the reference information (book, chapter, and verses).
3. The `Word` class manages individual word visibility and provides methods to hide or reveal words.
4. In the `Scripture` class:
   - `HideRandomWords` randomly selects words to hide using the `Word` class.
   - `GetDisplayText` assembles the scripture text with visible words and underscores for hidden words.
   - `IsCompletelyHidden` determines if the memorization process is complete.

---

## Constructors

### Scripture
- `Scripture(reference : Reference, text : string)`  
  Initializes the scripture with its reference and text. Splits the text into `Word` objects and stores them in the `_words` list.

### Reference
- `Reference(book : string, chapter : int, verse : int)`  
  Handles single-verse references.
- `Reference(book : string, chapter : int, startVerse : int, endVerse : int)`  
  Handles multi-verse references.

### Word
- `Word(text : string)`  
  Initializes the word with its text and sets `_isHidden` to `false`.

---

## Design Considerations
**Encapsulation:** All attributes are private, and public methods are provided for controlled access.
**Behavior Delegation:** The Scripture class delegates word hiding and visibility to the Word class, ensuring single-responsibility.
**Flexibility:**  By using Word objects instead of strings, the program can adapt to future changes (e.g., adding additional attributes to words).

## Class Diagram

```plaintext
Scripture
- _reference : Reference
- _words : List<Word>
+ HideRandomWords(numberToHide : int) : void
+ GetDisplayText() : string
+ IsCompletelyHidden() : bool

Reference
- _book : string
- _chapter : int
- _verse : int
- _endVerse : int
+ GetDisplayText() : string

Word
- _text : string
- _isHidden : bool
+ Hide() : void
+ Show() : void
+ IsHidden() : bool
+ GetDisplayText() : string
