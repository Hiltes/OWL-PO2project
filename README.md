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

# 🔧 Kluczowe fragmenty formularzy OWL

### 1. Dynamiczna walidacja i aktywacja przycisku

**Gdzie:** `LoginPanel` (metoda `ValidateFields`)  
**Co robi:** przy każdej zmianie w polach login/hasło sprawdza długość i włącza przycisk tylko gdy oba są poprawne.

```csharp
private void ValidateFields(object sender, EventArgs e)
{
    bool loginValid    = !string.IsNullOrWhiteSpace(LoginBox.Text) && LoginBox.Text.Length >= 4;
    bool passwordValid = PasswordBox.Text.Length >= 8;
    LoginButton.Enabled = loginValid && passwordValid;
}
```

- **Plusy**  
  - Użytkownik od razu widzi, czy może kliknąć „Zaloguj”.
  - Unikamy zbędnych wywołań logiki, gdy dane są oczywiście niepoprawne.

---

### 2. Rozróżnienie błędów logowania

**Gdzie:** `LoginPanel.HandleFailedLogin`  
**Co robi:** po nieudanym `LoginUser` rozróżnia sytuację „złe hasło” vs „nie ma użytkownika”:

```csharp
private void HandleFailedLogin(string username)
{
    if (_authService.CheckUser(username))
        MessageBox.Show("Niepoprawne hasło", "Błąd logowania", …);
    else
        MessageBox.Show("Nie znaleziono użytkownika", "Błąd logowania", …);
}
```

- **Plusy:**  
  - Lepsze UX: użytkownik wie, czy ma się zająć zapomnianym hasłem, czy najpierw założyć konto.  
  - Bezpieczeństwo: nie ujawniamy haseł, tylko istnienie loginu.

---

### 3. Zaawansowana walidacja w rejestracji

**Gdzie:** `RegisterPanel.ValidateFields`  
**Co robi:**  
- Sprawdza format e-mail (regex).  
- Wymaga od hasła min. 8 znaków, cyfry i znaku specjalnego.  
- Blokuje przycisk Rejestruj, dopóki wszystkie warunki nie są spełnione.

```csharp
bool emailValid    = Regex.IsMatch(EmailBox.Text,    @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
bool loginValid    = LoginBox.Text.Length >= 4;
bool passComplex   = PasswordBox.Text.Length >= 8 && Regex.IsMatch(PasswordBox.Text, "(?=.*\d)(?=.*[^\w\s])");
bool passwordsMatch= PasswordBox.Text == PasswordConfirmBox.Text;
RegisterButton.Enabled = emailValid && loginValid && passComplex && passwordsMatch;
```

- **Szczegóły:**  
  - `(?=.*\d)` i `(?=.*[^\w\s])` — lookaheady zapewniające cyfrę i znak specjalny.  
  - UI wymusza bezpieczeństwo jeszcze przed backendem.

---

### 4. Równomierne wypełnienie kolumn w DataGridView

**Gdzie:** `EventDetailsForm.LoadGridView`  
**Co robi:**  
- Ustawia `AutoSizeColumnsMode = Fill`.  
- Każdej kolumnie przydziela równą wagę.

```csharp
dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
float weight = 100f / dataGridView1.Columns.Count;
foreach (DataGridViewColumn col in dataGridView1.Columns)
{
    col.FillWeight = weight;
    col.Resizable  = DataGridViewTriState.False;
}
```

- **Plusy**  
  - Kolumny zawsze równomiernie zajmują całą szerokość.  
  - Użytkownik nie zmienia niechcący rozmiaru kolumn.

---

### 5. Obsługa tworzenia/edycji wydarzenia

**Gdzie:** `CreateEventForm.CrtEVBtm_Click`  
**Co robi:**  
- Sprawdza `EventId` (0 = nowe, !=0 = edycja).  
- Wywołuje `_eventService.NewEvent(...)` lub `.EditEvent(...)`.  
- Obsługa wyjątków `DbUpdateException` i ogólnych.

```csharp
if (EventId == 0)
    result = _eventService.NewEvent(...);
else
    result = _eventService.EditEvent(...);
```

- **Korzyści:**  
  - Jeden formularz dla dwóch scenariuszy → mniej duplikacji.  
  - Rollback i komunikaty o błędach użytkownika.

---

Każdy fragment poprawia UX, czytelność kodu i ułatwia dalszy rozwój.



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
