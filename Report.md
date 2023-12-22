# Instabug Challenge

## iOS Application Test Design

### Scenarios

#### 1. Task Creation

- **Description:** Confirm the ability to create a task, including adding a title and a due date, and marking it as completed.
- **Priority:** High
- **Business Impact:** Core functionality; non-functionality would discourage users from using the application.

#### 2. Task Reminder

- **Description:** Set a task reminder for a given time and wait to receive a notification.
- **Priority:** High
- **Business Impact:** Critical for most users; missed deadlines could erode user trust in the app.

#### 3. Device Sync

- **Description:** Create a task on the iOS app, log in from a web browser, and check if it is shown there too.
- **Priority:** High
- **Business Impact:** Core functionality; failure affects multi-device users.

#### 4. Recurring Tasks

- **Description:** Set a task as recurring (e.g., 'daily') and verify that it works as expected.
- **Priority:** Medium
- **Business Impact:** Important for users managing repeat or habitual tasks.

#### 5. Offline Functionality

- **Description:** Confirm app functionality with no connection, ensuring updates are synced once a connection is re-established.
- **Priority:** Medium
- **Business Impact:** Necessary for users in areas with weak or inconsistent connections.

#### 6. Task Deletion

- **Description:** Delete a task.
- **Priority:** Medium
- **Business Impact:** Users unable to clear tasks may experience interface clutter.

#### 7. Calendar Integration

- **Description:** Confirm iOS calendar app integration.
- **Priority:** Medium
- **Business Impact:** Essential for users relying on their device's native calendar.

#### 8. Third-Party Integration

- **Description:** Test integration with supported third-party apps (WhatsApp, Slack, and Zapier).
- **Priority:** Medium
- **Business Impact:** Important for heavy users needing external tools to enhance their use.

#### 9. Performance

- **Description:** Ensure smooth navigation, quick response times, and no crashes.
- **Priority:** Low
- **Business Impact:** Degraded performance frustrates users but may not have an immediate business impact.

#### 10. Accessibility

- **Description:** Conduct accessibility testing, including using a screen reader to confirm usability for visually impaired individuals.
- **Priority:** Low
- **Business Impact:** Ensures user inclusivity but may not have an immediate impact.

## Bug Reporting

All bugs found on the same environment - an iPhone 8 Plus, tested on both Wi-Fi and 4G.

#### 1. Filtering does not work

- No filtering options are displayed when selecting the filter feature under the three-dot menu.

#### 2. Completed tasks not always showing up in 'completed tasks' list

- In settings, a 'completed tasks' button is available. However, even if I have a completed task, an empty list is sometimes shown. This issue seems to occur randomly, and reproduction steps are uncertain.

#### 3. Top left 'square' button inconsistently working

- Sometimes, it brings up the 'tips' screen, while at other times, it does nothing.

#### 4. Non-functional 'tips' filtering button shown in the tips screen

- Upon switching to the notifications section or after using a filtering option, the button disappears, reappearing only if I dismiss the tips screen and open it again.

#### 5. 'Pricing Terms' unavailable

- 'Pricing Terms' button in the about screen functions the same as the 'Privacy Policy' one, opening the same page.

### UX Issues

#### 1. Inconsistent Letter Casing

- Many instances of inconsistent letter casing, including:
  - 'Terms of use' different from the other two choices in the app "About" section.
  - "sort" in lowercase, unlike other three-dot menu options.
  - "Week starts on" being different from other options in settings. (Consider renaming to "Start of Week")

#### 2. Misalignment of Text Box on the Main Screen

- On my device (iPhone 8 Plus), the text box to enter a new task is misaligned. It is placed on the lower border of the screen when it should be higher.

## Login Automation Test Cases

### 1. Happy Scenario

- **Input:**
  - Username: "standard_user"
  - Password: "secret_sauce"
- **Expected Result:**
  - Successful login without any error message.
  - Redirected to the store inventory.

### 2. Locked Out User

- **Input:**
  - Username: "locked_out_user"
  - Password: "secret_sauce"
- **Expected Result:**
  - Error message: "Epic sadface: Sorry, this user has been locked out."

### 3. Incorrect Username

- **Input:**
  - Username: "incorrect"
  - Password: "secret_sauce"
- **Expected Result:**
  - Error message: "Epic sadface: Username and password do not match any user in this service."

### 4. Incorrect Password

- **Input:**
  - Username: "standard_user"
  - Password: "incorrect"
- **Expected Result:**
  - Error message: "Epic sadface: Username and password do not match any user in this service."

### 5. Empty Username and Password

- **Input:**
  - Username: ""
  - Password: ""
- **Expected Result:**
  - Error message: "Epic sadface: Username is required."

### 6. Empty Username

- **Input:**
  - Username: ""
  - Password: "secret_sauce"
- **Expected Result:**
  - Error message: "Epic sadface: Username is required."

### 7. Empty Password

- **Input:**
  - Username: "standard_user"
  - Password: ""
- **Expected Result:**
  - Error message: "Epic sadface: Password is required."
