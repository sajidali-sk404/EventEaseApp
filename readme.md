# 🎉 EventEase

**EventEase** is a Blazor WebAssembly application for browsing, managing, and registering for events. Built with clean architecture, responsive UI, and robust state management, it offers a seamless experience for users and organizers alike.

---

## 🚀 Features

- 🗂️ **Event Listing** – Browse upcoming events with dynamic filtering
- 📄 **Event Details** – View full descriptions, dates, and locations
- 📝 **Registration Form** – Submit RSVP with validation for name and email
- 👤 **User Session Tracker** – Persist user identity and registrations across pages
- 🧾 **Attendance Tracker** – Monitor event participation in real time
- 📱 **Responsive Design** – Optimized for desktop and mobile
- 🛠️ **Production-Ready** – Trimmed, compressed, and ready for deployment

---

## 🧠 Technologies Used

- **Blazor WebAssembly**
- **C# / .NET 8**
- **CSS Grid & Flexbox**
- **Dependency Injection**
- **DataAnnotations for Validation**
- **Scoped Services for State Management**

---

## 📦 Project Structure

```
EventEase/ 
│ 
├── Models/ 
│ ├── Event.cs
│ └── Registration.cs 
│ 
├── Services/ 
│ ├── IEventService.cs 
│ ├── EventService.cs 
│ └── UserSessionTracker.cs 
│ 
├── Pages/ 
│ ├── EventList.razor 
│ ├── EventDetails.razor 
│ ├── RegistrationForm.razor 
│ └── EditEvent.razor 
│ 
├── Shared/ 
│ ├── EventCard.razor 
│ ├── SearchBar.razor 
│ └── Toast.razor (optional) 
│ 
└── wwwroot/ 
└── css/ 
└── site.css
```

---

## 🧑‍💻 How to Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/sajidali-sk404/EventEaseApp.git
   cd EventEase
   ```
2. Restore dependencies:
   ```bash
   dotnet restore
   ```
3. Run the app:
    ```bash
    dotnet run
    ```

    
Let me know if you want help customizing this for GitHub, adding screenshots, or writing a `CONTRIBUTING.md` file. You’re ready to showcase this with pride!
