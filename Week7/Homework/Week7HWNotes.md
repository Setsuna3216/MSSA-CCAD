# MSSA Week 7 – Data Structures & Algorithms Notes

## 1. Merge Sort (Assignment 7.2 – Q1)

**Concept:** Divide and Conquer + Recursion

Merge Sort divides an array into smaller arrays, sorts them, and merges them back together.

### How It Works

1. **Divide:** Split the array into two halves.
2. **Recursion:** Keep splitting until each array contains one or zero elements.
3. **Merge:** Compare elements from both sorted arrays.
4. **Return:** Combine the elements into one sorted array.

Example:

```text
[8, 3, 5, 1]
    /     \
 [8, 3]  [5, 1]
  /  \    /  \
[8] [3] [5] [1]
  \  /    \  /
 [3, 8]  [1, 5]
     \    /
  [1, 3, 5, 8]
```

### Important C# Concepts

**Base Case:** Stops recursion.

```csharp
if (numbers.Length <= 1)
{
    return numbers;
}
```

**Recursive Call:** A method calls itself to solve a smaller problem.

```csharp
numbersLeft = MergeSort(numbersLeft);
numbersRight = MergeSort(numbersRight);
```

**Merging:** Use three indexes:

- `i` → Current position in the left array
- `j` → Current position in the right array
- `k` → Current position in the merged array

Continue comparing while both arrays have remaining elements.

```csharp
while (i < numbersLeft.Length && j < numbersRight.Length)
```

After one array is exhausted, copy the remaining elements from the other array.

### Complexity

- Time: `O(n log n)`
- Extra Space: `O(n)`

### Common Mistakes

- Forgetting the recursion base case.
- Using `||` instead of `&&` when comparing both arrays.
- Forgetting to copy remaining elements.
- Forgetting to return the merged array.

---

## 2. Two Pointers – Reverse Vowels (Assignment 7.2 – Q2)

**Concept:** String Manipulation + Two Pointers

Reverse only the vowels (`a, e, i, o, u`) while keeping other characters in their original positions.

Example:

```text
Input:  hello
Output: holle
```

### How It Works

1. Convert the string to a `char[]`.
2. Set `left` to the first index.
3. Set `right` to the last index.
4. Move `left` forward until it finds a vowel.
5. Move `right` backward until it finds a vowel.
6. Swap the two vowels.
7. Continue until the pointers meet.

### Important C# Concepts

**Convert String to Char Array**

```csharp
char[] letters = s.ToCharArray();
```

Strings are immutable in C#. A character array allows modification of individual elements.

**Two Pointers**

```csharp
int left = 0;
int right = letters.Length - 1;
```

**Check for Vowels**

```csharp
"aeiou".Contains(char.ToLower(letters[left]))
```

**NOT Operator**

```csharp
!condition
```

Reverses a Boolean condition.

**Pointer Boundary**

```csharp
while (left < right)
```

Prevents pointers from crossing. Also check this condition inside the vowel-search loops before accessing an array element.

### Complexity

- Time: `O(n)`
- Extra Space: `O(n)` because of the character array.

### Common Mistakes

- Moving `right++` instead of `right--`.
- Swapping before both pointers find vowels.
- Forgetting to move pointers after swapping.
- Accessing an array index outside its valid range.

---

## 3. Dictionary – Valid Anagram (Assignment 7.2 – Q3)

**Concept:** Dictionary + Character Frequency Counting

An anagram contains the same characters with the same frequency, but possibly in a different order.

Examples:

```text
anagram / nagaram → true
rat / car         → false
aab / abb         → false
```

### How It Works

1. Compare the lengths of the two strings.
2. Create a Dictionary to store character frequencies.
3. Count every character in the first string.
4. Traverse the second string and decrease the corresponding counts.
5. Return false if a character is missing or its count becomes negative.
6. Return true if all characters are processed successfully.

### Important C# Concepts

**Dictionary Declaration**

```csharp
Dictionary<char, int> charCount = new();
```

- `Key` → Character
- `Value` → Frequency

**Check Whether a Key Exists**

```csharp
charCount.ContainsKey(c)
```

**Increase Count**

```csharp
charCount[c]++;
```

**Add a New Key**

```csharp
charCount.Add(c, 1);
```

**Decrease Count**

```csharp
charCount[c]--;
```

### Complexity

- Time: `O(n)` average
- Extra Space: `O(k)` where k is the number of distinct characters.

### Common Mistakes

- Adding new characters while validating the second string.
- Forgetting to check for negative counts.
- Using a Dictionary key without confirming it exists.
- Assuming two strings are anagrams just because they contain the same unique letters.

---

## 4. Binary Search Tree (Assignment 7.3)

**Concept:** Tree + Recursion + Binary Search

A Binary Search Tree (BST) is a binary tree where:

- Values in the left subtree are smaller than the current node.
- Values in the right subtree are greater than the current node.

Assume the tree contains no duplicate values.

Example:

```text
        8
       / \
      3   10
     / \
    1   6
```

### Searching for a Value

To find `6`:

1. Start at root `8`.
2. Since `6 < 8`, move left.
3. At node `3`, since `6 > 3`, move right.
4. Find node `6` and return it.

### Important C# Concepts

**TreeNode**

A TreeNode usually contains:

- `val` → Current node value.
- `left` → Reference to left child.
- `right` → Reference to right child.

**Nullable Reference**

```csharp
TreeNode? left;
TreeNode? right;
```

The `?` allows the references to be `null`.

**Recursion Base Cases**

- If the current node is `null`, return `null`.
- If the current node matches the target, return that node.

**Recursive Search**

```csharp
return SearchBST(root.left, val);
```

or:

```csharp
return SearchBST(root.right, val);
```

`return` is important because it passes the search result back through previous recursive calls.

### Complexity

| Situation | Time |
|---|---|
| Balanced BST | O(log n) |
| Unbalanced BST (worst case) | O(n) |

Recursive stack space: `O(h)`, where h is the tree height.

### Common Mistakes

- Forgetting to check `root == null`.
- Returning the original root instead of the found node.
- Calling recursion without returning its result.
- Confusing a TreeNode reference with an integer value.

---

## 5. OOP – Parking System (Assignment 7.4)

**Concept:** Class + Fields + Constructor + Methods + State Management

Design a parking system with three parking-space types:

| carType | Space |
|---|---|
| 1 | Big |
| 2 | Medium |
| 3 | Small |

A car can only use a space of its own type.

### Class Structure

```text
ParkingSystem
│
├── Fields
│   ├── bigSpace
│   ├── midSpace
│   └── smlSpace
│
├── Constructor
│   └── Initialize available spaces
│
└── addCar(carType)
    ├── Check available space
    ├── Decrease count if available
    └── Return true or false
```

### Important C# Concepts

**Fields**

Store information belonging to an object. Their values persist between method calls.

**Constructor**

Initializes an object when it is created.

```csharp
ParkingSystem parking = new ParkingSystem(1, 1, 0);
```

**State Management**

When a car parks successfully, the number of available spaces must decrease.

```csharp
bigSpace--;
```

**Boolean Return**

- `true` → Parking succeeded.
- `false` → No available space.

### Common Mistakes

- Declaring parking-space counters as local variables in the Constructor.
- Forgetting to decrease the space count after parking.
- Forgetting to return false when no spaces remain.
- Not handling an invalid carType.

---

## 6. Important C# Concepts Review

| Concept | Meaning |
|---|---|
| Recursion | A method calls itself |
| Base Case | Condition that stops recursion |
| `return` | Ends a method and passes back a result |
| `char[]` | Modifiable array of characters |
| Two Pointers | Two indexes used to traverse data |
| `Dictionary<K,V>` | Stores key-value pairs |
| `ContainsKey()` | Checks whether a key exists |
| `null` | No object reference |
| Constructor | Initializes an object |
| Field | Stores an object's state |
| `&&` | Logical AND |
| `||` | Logical OR |
| `!` | Logical NOT |
| `O(n)` | Linear time complexity |
| `O(log n)` | Logarithmic time complexity |
| `O(n log n)` | Linearithmic time complexity |

---

## 7. Review Checklist

- [ ] Explain Merge Sort without looking at code.
- [ ] Explain why recursion needs a base case.
- [ ] Trace how a recursive result returns to the caller.
- [ ] Rebuild Reverse Vowels using two pointers.
- [ ] Explain why strings need to be converted to char arrays for in-place character changes.
- [ ] Rebuild Valid Anagram using a Dictionary.
- [ ] Explain the BST left/right search rule.
- [ ] Explain the difference between returning a TreeNode and returning its value.
- [ ] Rebuild ParkingSystem without looking at the original code.
- [ ] Explain the difference between Fields and Local Variables.

## Key Takeaways

1. **Merge Sort:** Divide, recursively sort, and merge.
2. **Two Pointers:** Move two indexes to efficiently search or modify data.
3. **Dictionary:** Count and look up values using keys.
4. **BST:** Use ordered tree structure to avoid searching unnecessary branches.
5. **OOP:** Use fields to preserve object state across method calls.

**Study Goal:** Understand why each algorithm works rather than memorizing the code.