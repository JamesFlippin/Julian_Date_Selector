# Calendar Date to Julian Date Selector

**Detailed End User Guide**

---

## Introduction

The **Calendar Date to Julian Date Selector** is a Windows application that allows you to:

- Convert any calendar date to a Julian date in multiple formats.
- Convert a Julian date (in several formats) back to a standard calendar date.
- Copy results to the clipboard.
- Use dark mode for comfortable viewing.
- Access help, about, and exit options.

---

## Main Window Overview

When you start the program, you will see:

- A **Month Calendar** for picking dates.
- A **Date Picker** (drop-down calendar).
- A **Julian Date Output** area.
- A **Format Selection** menu.
- A **Julian to Calendar Converter** section.
- A **Status Bar** at the bottom for feedback.
- Menu options for Dark Mode, Help, About, and Exit.

---

## 1. Converting Calendar Date to Julian Date

### A. Selecting a Date

- **Using the Month Calendar:**  
  Click any date on the calendar to select it.  
  The selected date will be highlighted.

- **Using the Date Picker:**  
  Use the drop-down or arrow keys to select a date.  
  The calendar and date picker are synchronized—changing one updates the other.

### B. Viewing the Julian Date

- The Julian date for the selected calendar date is shown in the **Julian Date Output** box.
- The format of the Julian date depends on your selection (see below).

### C. Changing the Julian Date Format

- Go to the **Set Format** menu at the top.
- Choose from:
  - **DDD**: Day of year (e.g., `123`)
  - **YYDDD**: Last two digits of year + day of year (e.g., `24123`)
  - **YY DDD**: Last two digits of year, space, day of year (e.g., `24 123`)
  - **YYYYDDD**: Full year + day of year (e.g., `2024123`)
  - **YYYY DDD**: Full year, space, day of year (e.g., `2024 123`)
- The selected format is displayed next to "Currently Selected Format".

### D. Copying the Julian Date

- Click the **Copy to the Clipboard** button to copy the Julian date.
- If **Notify on Copy** is checked, a message box will confirm the copy.

---

## 2. Converting Julian Date to Calendar Date

### A. Entering a Julian Date

- In the **Convert Julian to Calendar Date** section, enter a Julian date in any of these formats:
  - `DDD` (e.g., `123` for the 123rd day of the current year)
  - `YYDDD` (e.g., `24123` for the 123rd day of 2024)
  - `YY DDD` (e.g., `24 123`)
  - `YYYYDDD` (e.g., `2024123`)
  - `YYYY DDD` (e.g., `2024 123`)
  - You can use spaces, dashes, or slashes as separators (e.g., `24-123`, `2024/123`).

### B. Converting

- Click the **Convert Julian to Calendar date->** button.
- The corresponding calendar date will appear in the output box.
- If the input is invalid, you will see "Invalid Julian date".

### C. Clearing Input and Output

- Click the **X** button to clear both the Julian input and the calendar output fields.

### D. Copying the Calendar Date

- Double-click the calendar date output to copy it to the clipboard.
- The status bar will confirm the copy.

---

## 3. Date Search Feature

- In the **Date Search** group:
  - Enter a date in the format `MM/DD/YYYY` in the masked text box, or use the date picker.
  - Click the **Find** button.
  - The calendar will jump to and highlight the date if valid.
  - The status bar will show if the date was found or not.

---

## 4. Dark Mode

- Enable dark mode from the **Dark-Mode** menu at the top.
- All forms and controls will switch to a dark color scheme for easier viewing in low light.

---

## 5. Help, About, and Exit

- **Help:**
  - Use the **Help** menu to access the help website for more information.
- **About:**
  - Use the **About** menu to see program and author information.
- **Exit:**
  - Use the **Exit** menu to close the program.

---

## 6. Status Bar

- The status bar at the bottom of the window provides feedback on actions such as:
  - Date search results.
  - Copy operations.
  - Error messages.

---

## 7. Error Handling

- If you enter an invalid date or Julian date, the program will display an error message.
- The Julian date conversion checks for leap years and valid day-of-year ranges.

---

## 8. Tips and Best Practices

- **Formats:**  
  Always check the format you are using for Julian dates. The program accepts several common formats.
- **Copying:**  
  Use the copy features to quickly transfer results to other applications.
- **Dark Mode:**  
  Toggle dark mode for comfortable viewing, especially at night.
- **Feedback:**  
  Watch the status bar for helpful messages about your actions.

---

## 9. Support and License

- **Help Website:**  
  [https://www.flippintechnologies.com/calendardatetojuliandateselector](https://www.flippintechnologies.com/calendardatetojuliandateselector)
- **GitHub Repository:**  
  [https://github.com/JamesFlippin/Julian_Date_Selector](https://github.com/JamesFlippin/Julian_Date_Selector)
- **License:**  
  GNU GENERAL PUBLIC LICENSE Version 3

---

_Programmer: James G. Flippin, Jr._

---
