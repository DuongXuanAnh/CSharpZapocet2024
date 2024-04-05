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

* MySQL Server 
* Máte nainstalovanou verzi >= [.NET 8.0](https://dotnet.microsoft.com/download/dotnet/8.0) specifickou pro Windows, která podporuje Windows Forms.
* Váš operační systém je Windows, protože tento projekt využívá Windows Forms, které nejsou podporovány na Linuxu ani macOS.

Pro spuštění jednotkových testů budete potřebovat:

- **.NET SDK 8.0** nebo vyšší: Testy jsou cíleny na .NET 8.0, což vyžaduje odpovídající verzi .NET SDK.
- **Visual Studio 2022** nebo novější: Doporučeno pro vývoj a spouštění testů z IDE s podporou .NET 8.0 a Windows Forms aplikací.
- **xUnit testovací framework**: Testy používají xUnit verze 2.5.3.
- **xUnit Runner pro Visual Studio**: Umožňuje spouštět xUnit testy přímo z Visual Studio Test Exploreru.



### Instalace

Pro instalaci postupujte podle těchto kroků:

1. Klonujte repozitář:
   - `git clone https://github.com/DuongXuanAnh/CSharpZapocet2024.git`
2. Konfigurace databáze
   - Nainstalujte MySQL Server a vytvořte novou databázi pojmenovanou `book_store_manager`.
   - Spuštěte obsah book_store_manager.sql v Query MySQL Server v databázi `book_store_manager`.
3. Přejděte do adresáře projektu:
   - `cd BooksManagement`
4. Otevřete projekt ve Visual Studiu nebo jakémkoliv jiném .NET kompatibilním IDE.
5. Sestavte projekt:
   - Ve Visual Studiu to můžete udělat kliknutím na Build > Build Solution.
6. Spusťte projekt:
   - Ve Visual Studiu to můžete udělat kliknutím na Debug > Start Debugging.

## Spuštění testů

- **Pomocí Visual Studio**:
  1. Otevřete Test Explorer přes `Test > Test Explorer`.
  2. Klikněte na "Run All" nebo vyberte specifické testy, které chcete spustit.

- **Pomocí příkazové řádky**:
  1. Otevřete příkazovou řádku nebo PowerShell v kořenovém adresáři projektu.
  2. Spusťte `dotnet test`, což najde a spustí všechny testy ve vašem řešení.

## Další informace

Pro další informace o xUnit a jeho použití se podívejte na [oficiální dokumentaci xUnit](https://xunit.net/).