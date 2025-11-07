# Hotel Aurelia – Rezervační systém  
Webová aplikace vytvořená v ASP.NET Core MVC pro správu hotelových rezervací, včetně výběru pokojů, kontroly obsazenosti a ukládání rezervací do SQLite databáze.

---

## Funkce aplikace

### 1. Rezervace pokojů
- uživatel zadá jméno, datum příjezdu, odjezdu a typ pokoje (2 nebo 4 lůžka)
- systém automaticky najde volný pokoj podle počtu lůžek
- zabrané pokoje se nekolidují s jinými rezervacemi
- validace:
  - datum příjezdu nesmí být v minulosti  
  - datum odjezdu musí být za datem příjezdu  
  - dostupnost pokoje pro dané datum  

---

### 2. Přehled rezervací (admin sekce)
- tabulka všech rezervací
- možnost mazat jednotlivé rezervace
- automatická aktualizace seznamu

---

### 3. Správa pokojů
- pokoje jsou uložené v databázi (počet lůžek, číslo pokoje)
- systém vybírá vždy první volný podle typu

---

### 4. Moderní webová prezentace hotelu
Stránky obsahují:
- úvodní stránku s hrdinou obrázkem
- wellness sekci
- aktivity v okolí
- přehled pokojů
- kontaktní stránku
- elegantní design pomocí Bootstrapu + vlastní CSS

---

## Použité technologie

- **ASP.NET Core MVC 8**
- **Entity Framework Core**
- **SQLite databáze**
- **Bootstrap 5**
- **Razor Pages**
- **C# 12**

