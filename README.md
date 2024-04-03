# Program pro správu knihovny


# Úvod

Tento program slouží ke správě knižního fondu a zákazníků v knihovně. Umožňuje editovat knihy, jejich autory a žánry, a dále spravovat půjčování knih registrovaným zákazníkům.

## Funkce programu:

### Správa knih:
- Zobrazení detailů knihy (název, autor, žánr, dostupnost). Detail knihy bude obsahovat název, autora, žánr, rok vydání, cenu, dostupnost.
- Vyhledávání knih podle názvu, autora, žánru. Kritéria pro vyhledávání zahrnují název knihy, autora, žánru.
- Přidávání, upravování a mazání knih v databázi.
- Přidávání nových autorů do databáze.

### Správa zákazníků:

#### Typy zákazníků:
  - Kupující:
    - Zákazníci, kteří si knihy kupují.
    - Neregistrují se v programu.
  - Půjčovatelé:
    - Zákazníci, kteří si knihy půjčují.
    - Musí se zaregistrovat v programu.
    - Registrace zahrnuje zadání: jména, příjmení, kontaktních údajů (email, telefonní číslo).

### Registrace:
- Registrace probíhá v programu a je nutná pro možnost půjčování knih.
- Po registraci obdrží zákazník identifikační číslo (ID), které bude používat při půjčování knih.

### Půjčování knih:
- Program bude zobrazovat aktuální počet dostupných kusů u každé knihy.
- Půjčování knih je dostupné pouze registrovaným uživatelům.
- Podle ID zákazníka dokážeme dohledat informaci o tom, jakou knihu si půjčil, kdy si ji půjčil a kdy ji má vrátit.
- Po vrácení knihy se smaže jeho informace o půjčování.

### Zapůjčené knihy:
- V programu zle zobrazit informace o tom, kdo si jakou knihu půjčil, kdy si ji půjčil a kdy ji má vrátit.
- Po vrácení knihy se smaže informace o tom kdo si co půjčil.
### Penalizace za zpoždění nebo ztrátu knihy
- Datum vrácení knihy je stanoveno při půjčení knihy.
- Pokud zákazník vrátí knihu po tomto datu nebo ztratí knihu, bude mu účtována pokuta.

## Technologie:
- Programovací jazyk: C#
- Vývojové prostředí: Windows Forms
- Databáze: MariaDB
- Správa databáze: phpMyAdmin
- Připojení k databázi: MySql.Data.MySqlClient (MySQL konektor/NET)
- Testovací framework: xUnit


### Předpoklady

Než začnete, ujistěte se, že splňujete následující požadavky:

* Máte nainstalovanou verzi >= [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) specifickou pro Windows, která podporuje Windows Forms.
* Váš operační systém je Windows, protože tento projekt využívá Windows Forms, které nejsou podporovány na Linuxu ani macOS.



### Instalace

Pro instalaci postupujte podle těchto kroků:

1. Klonujte repozitář:
   - `git clone https://github.com/vaseuzivatelskejmeno/BooksManagement.git`
2. Přejděte do adresáře projektu:
   - `cd BooksManagement`
3. Otevřete projekt ve Visual Studiu nebo jakémkoliv jiném .NET kompatibilním IDE.
4. Sestavte projekt:
   - Ve Visual Studiu to můžete udělat kliknutím na Build > Build Solution.
5. Spusťte projekt:
   - Ve Visual Studiu to můžete udělat kliknutím na Debug > Start Debugging.