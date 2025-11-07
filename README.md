# Hotel – Rezervační systém  
Tato aplikace byla vytvořena jako součást mého portfolia. Ukazuje práci s ASP.NET Core MVC, databázemi, validací, návrhem UI a implementací logiky pro rezervace.

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
## Screenshoty
<details>
<summary>Úvodní stránka</summary>
Hlavní prezentace hotelu s hlavním obrázkem a jednoduchou navigací.
<img width="1899" height="942" src="https://github.com/user-attachments/assets/3dd96bb4-53d8-479b-83a8-358a41071126" />
<img width="1904" height="887" src="https://github.com/user-attachments/assets/003998c4-22a8-40a1-adbc-1793d821cc02" />

</details>

<details>
<summary>Aktivity</summary>
Přehled aktivit dostupných hotelovým hostům, jako je lyžování, wellness nebo bruslení.
<img width="1895" height="1069" src="https://github.com/user-attachments/assets/5b5ddb3c-d013-4559-ad86-d568e23ad255" />
</details>

<details>
<summary>Kontakt</summary>
Kontaktní stránka s adresou, mapou a telefonním spojením na recepci.
<img width="1895" height="946" src="https://github.com/user-attachments/assets/c1d1b2a3-0511-4611-a241-49de56277d42" />
</details>

<details>
<summary>Rezervační formulář</summary>
Formulář, kde návštěvník vyplní jméno, datum pobytu a typ pokoje. Probíhá validace i kontrola dostupnosti.
<img width="699" height="714" src="https://github.com/user-attachments/assets/f196e30a-0005-4880-bfe9-df0866358757" />
</details>

<details>
<summary>Seznam rezervací</summary>
Administrační přehled všech proběhlých rezervací s možností jejich mazání.
<img width="1900" height="909" src="https://github.com/user-attachments/assets/964b0827-997e-412f-b7dd-bbd5030e6065" />
</details>

## Použité technologie

- **ASP.NET Core MVC 8**
- **Entity Framework Core**
- **SQLite databáze**
- **Bootstrap 5**
- **Razor Views (MVC)**
- **C#**

