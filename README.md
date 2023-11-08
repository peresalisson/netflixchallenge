### This is my solution to the Netflix Interview Challenge I saw on 'The Coding Sloth' channel on YouTube. 

# The challenge:

Given a string s consisting of small English letters, find and return the first instance of a non-repeating character in it. If there is no such character, return an underline.
  Example:
  
  For s = "abacabad", the output should be "solution(s) = 'c'". There are 2 non-repeating characters in the string: 'c' and 'd'. Return 'c' since it appears in the string first 
  
  For = "abacabaabacaba", the output should be "solutions(s) = "_"". There are no characteres in this string that do not repeat.

## Breaking down my code:

In summary, this code iterates through the string and checks each character to determine whether it's unique.

1. I used a `for` loop to iterate through the characters of the string. The `i` represents the current index in the string and goes up to the length of the string `s`.
2. Inside the loop, it retrieves the character at the current index and stores it in the variable `currentChar`. This character is the one being checked for uniqueness.
3. It initializes `isUnique` to `true`. This variable is used to track whether the `currentChar` is unique in the string.
4. I have used another `for` loop with a variable `j` to compare the `currentChar` with every other character in the string.
5. Within the nested loop, it checks if the character at index `i` (stored in `currentChar`) is equal to the character at index `j` and ensures that `i` is not equal to `j`. If this condition is met, it means that the `currentChar` is not unique because there is at least one other occurrence of it in the string.
6. If it finds a non-unique occurrence of the `currentChar`, it sets `isUnique` to `false` and breaks out of the nested loop.
7. After the nested loop completes, it checks the value of `isUnique`. If `isUnique` is still `true` after checking all characters in the string, it means that `currentChar` is unique, and it returns `currentChar`.
8. If the loop completes and no unique character is found, it returns `'_'` to indicate that there are no non-repeating characters in the string.

