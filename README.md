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
- možnost mazat jednotlivé rezervace pouze pro přihlášené uživatele
- automatická aktualizace seznamu

---

### 3. Správa pokojů
- pokoje jsou uložené v databázi (počet lůžek, číslo pokoje)
- systém vybírá vždy první volný podle typu

---

### 4. Přihlášení uživatelů
- registrace nových uživatelů
- přihlášení pomocí emailu a hesla

---

### 5. Moderní webová prezentace hotelu
Stránky obsahují:
- úvodní stránku s hero obrázkem
- wellness sekci
- aktivity v okolí
- přehled pokojů
- kontaktní stránku
- elegantní design pomocí Bootstrapu + vlastní CSS

---
## Screenshoty
<details>
<summary>Úvodní stránka</summary>
- Hlavní prezentace hotelu s hero obrázkem a jednoduchou navigací.
<img width="1899" height="944" src="https://github.com/user-attachments/assets/b25b4cc2-0794-4c18-8ae8-35c1d2364b32" />
<img width="1905" height="792" src="https://github.com/user-attachments/assets/3e2aae93-9f7d-43c8-b56d-42e2fea4aba7" />

</details>

<details>
<summary>Aktivity</summary>
- Příklad jedné z vedlejších stránek.
<img width="1904" height="942" alt="{E670742F-0785-4944-A337-40193533F81F}" src="https://github.com/user-attachments/assets/737afd7b-88e2-4476-945a-c7ee7972de83" />
</details>

<details>
<summary>Rezervační formulář</summary>
- Formulář, kde návštěvník vyplní jméno, datum pobytu a typ pokoje. Probíhá validace i kontrola dostupnosti.
<img width="1901" height="947" src="https://github.com/user-attachments/assets/694a4b1a-a3d7-4993-bd45-bf9c02c1730f" />
</details>

<details>
<summary>Seznam rezervací</summary>
Přehled všech proběhlých rezervací s možností jejich mazání.
<img width="1900" height="909" src="https://github.com/user-attachments/assets/964b0827-997e-412f-b7dd-bbd5030e6065" />
</details>

<details>
<summary>Registrační a přihlašovací formulář</summary>
<img width="677" height="489" alt="{A40AC65D-4B65-4FE5-B407-A4F5CDF7E89B}" src="https://github.com/user-attachments/assets/7906a6e3-554a-4855-9efe-f86be38d1fae" />
<img width="640" height="424" src="https://github.com/user-attachments/assets/8289c11b-c828-4cfb-a90d-2449579e9c76" />
</details>


## Použité technologie

- **ASP.NET Core MVC 8**
- **Entity Framework Core**
- **SQLite databáze**
- **Bootstrap 5**
- **Razor Views (MVC)**
- **C#**

