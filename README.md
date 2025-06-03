# OWL – Organizer Wydarzeń Lokalnych

Projekt realizowany w ramach przedmiotu **Programowanie Obiektowe 2**.

## 📌 Opis aplikacji

**OWL** to aplikacja desktopowa służąca do organizowania i zarządzania wydarzeniami dla firm. Umożliwia użytkownikom:

- Tworzenie, edytowanie i usuwanie wydarzeń
- Przeglądanie listy nadchodzących wydarzeń
- Przypisanie sięuczestnikom do danego wydarzenia
- Logowanie i rejestracje użytkowników
- 
## 🗃️ Opis bazy danych

Aplikacja korzysta z lokalnej bazy danych (np. SQLite) do przechowywania informacji o wydarzeniach i uczestnikach. Struktura bazy danych obejmuje:

- **Events**: Tabela przechowująca informacje o wydarzeniach
- **Participants**: Tabela zawierająca dane uczestników którzy biorą udział
- **User**: Tabela przechowujące informacje o użytkowniku z wyjątkiem haseł

Relacja między tabelami:

- Jeden uczestnik może być przypisany do wielu wydarzeń
- Jedno wydarzenie może mieć wielu uczestników
- Jedno Wydarzenie może mieć Jednego Organizatora(User)

## ⚙️ Konfiguracja i uruchomienie aplikacji

###Pakiety NuGet:
1. Dodaj pakiety NuGet:
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Design
Microsoft.EntityFrameworkCore.Tools
Microsoft.Extensions.Configuration.Json
Npgsql.EntityFrameworkCore.PostgreSQL

### Krok po kroku

1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/Hiltes/OWL-PO2project.git
   ```

2. Otwórz plik `OWL.sln` w Visual Studio.

3. Przy pierwszym uruchomieniu aplikacja automatycznie utworzy lokalną bazę danych z przykładowymi wydarzeniami i użytkownikami.

4. Uruchom aplikację, naciskając `F5` lub klikając przycisk "Start".


## 🎨 Kolorystyka interfejsu

- **Tło**: RGB(195, 193, 193)
- **Główny kolor**: RGB(122, 115, 150)
- **Kolor dodatkowy**: RGB(61, 47, 75)
- **Kolor specjalny**: RGB(243, 105, 63)
- **Kolor specjalny dodatkowy**: RGB(219, 138, 116)

## 📁 Struktura projektu

- `OWL/`: Główny katalog aplikacji zawierający pliki źródłowe
- `OWL.sln`: Plik rozwiązania Visual Studio
- `README.md`: Niniejszy plik dokumentacji

### 📂 Data/
Zawiera klasę `OwlDbContext.cs`, która definiuje kontekst bazy danych przy użyciu Entity Framework. Określa tabele (`DbSet<>`) i zarządza połączeniem z bazą.

### 📂 Forms/
Zawiera wszystkie formularze interfejsu graficznego (Windows Forms), m.in. kalendarz, formularz tworzenia wydarzeń, logowania, rejestracji oraz główne okno aplikacji.  
Każdy formularz posiada odpowiadające pliki `.Designer.cs` (generowane automatycznie) oraz `.resx` (zasoby formularza).

### 📂 Migrations/
Zawiera pliki migracji wygenerowane przez Entity Framework.  
Służą do tworzenia i aktualizacji struktury bazy danych.

### 📂 Models/
Zawiera definicje modeli danych: użytkowników, wydarzeń i relacji uczestnictwa.  
Modele te są odzwierciedleniem tabel w bazie danych.

### 📂 Seeders/
Zawiera logikę do początkowego zapełniania bazy danych przykładowymi danymi (np. testowe wydarzenia i użytkownicy).

### 📂 Services/
Warstwa logiki aplikacji.  
Zawiera klasy do obsługi autoryzacji, operacji na wydarzeniach i użytkownikach oraz zarządzania sesją użytkownika.
