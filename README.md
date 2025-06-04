# WpfBlazor.MudTemplate

A clean template that combines **WPF** with **Blazor** using `BlazorWebView`, along with the modern **MudBlazor** component library. Designed for modularity, rapid prototyping, and separation of concerns.

## ✨ Features

- **WPF Integration**: Embeds Blazor components inside a native WPF application using `BlazorWebView`.
- **MudBlazor UI**: Uses [MudBlazor](https://mudblazor.com/) to provide a sleek, responsive UI experience.
- **Modular Architecture**: Separates UI logic into a Razor Class Library (RCL) for reusability and maintainability.
- **Quick Start**: Minimal setup required – start building immediately.

## 📁 Project Structure

```
WpfBlazor.MudTemplate/
├── RazorClassLibrary/       # Contains shared Blazor components, pages, and styles
├── WpfBlazor.MudTemplate/   # WPF host app with BlazorWebView
│   └── MainWindow.xaml      # Main WPF window embedding Blazor
├── WpfBlazor.MudTemplate.sln
```

## 🚀 Getting Started

### Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0) or later
- Visual Studio 2022+ or Rider (with .NET support)

### Running the App

1. **Clone the repository**
   ```bash
   git clone https://github.com/Destuur/WpfBlazor.MudTemplate.git
   cd WpfBlazor.MudTemplate
   ```

2. **Open the solution**

   Open `WpfBlazor.MudTemplate.sln` in your IDE.

3. **Run the project**
   ```bash
   dotnet run --project WpfBlazor.MudTemplate
   ```

## 🧪 Example UI

The template includes a sample UI showcasing a basic MudBlazor component setup. This can be extended to build more complex interfaces.

## 🛠️ Customization

- **Styling**: Adjust the MudBlazor theme for light/dark modes, primary colors, typography, etc.
- **Navigation**: Add new Razor pages in the Razor Class Library and update the navigation layout.
- **Data**: Integrate backend services or APIs as needed.

## 📄 License

This project is licensed under the [MIT License](LICENSE).

---

Feel free to fork or contribute to improve the template!
