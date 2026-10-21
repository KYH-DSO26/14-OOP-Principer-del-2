# 14 OOP Principer del 2

### Polymorfism, klasshierarkier, undantag, starkt sammanhang och lös koppling

# Gröna uppgifter (Polymorfism & Virtuella medlemmar)

_Fokus på grundläggande polymorfism (mångformighet) med hjälp av virtuella metoder, basklassreferenser och metodöverlagring._

## Uppgift 1: Virtuell metod (Djur och Hund)

Skapa en basklass Djur med en **virtuell metod** (virtual) som heter GörLjud(). Metoden ska skriva ut ett generellt ljud. Skapa underklassen Hund som använder override för att skriva ut "Hunden skäller".

## Uppgift 2: Polymorfism med basklassreferens

Använd klasserna från Uppgift 1. Skapa en variabel av typen Djur i Main, men instansiera den som en Hund. Anropa GörLjud() och observera polymorfismen i praktiken.

## Uppgift 3: Array av polymorfa objekt

Skapa ytterligare en underklass till Djur som heter Katt. Skapa sedan en array av typen Djur\[\] i Main som innehåller både en Hund och en Katt. Loopa igenom arrayen och anropa GörLjud() på varje element.

## Uppgift 4: Typkontroll och typomvandling (is och as)

Loopa igenom din array från Uppgift 3. Använd nyckelordet is för att kontrollera om det aktuella djuret är en Hund. Om det är en hund, typomvandla det och anropa en unik metod ViftaPåSvansen().

## Uppgift 5: Statisk polymorfism (Metodöverlagring)

Skapa en klass Skrivare. Skapa två metoder med samma namn SkrivUt(). Den ena ska ta emot en string och den andra en int. Visa hur kompilatorn väljer rätt metod baserat på parametern (överlagring/overloading).

# Gula uppgifter (Verkliga klasshierarkier & Undantagshantering)

_Här tillämpas strukturerade hierarkier från verkliga system samt grundläggande felhantering med try-catch._

## Uppgift 6: Verklig hierarki – Betalsystem (Betalning)

Skapa en basklass Betalning med egenskapen Belopp och en virtuell metod ProcessaBetalning(). Skapa underklasserna Kreditkort och Swish. Implementera specifika utskrifter för hur varje betalmetod processas.

## Uppgift 7: Verklig hierarki – Användarsystem (Användare)

Skapa en basklass Användare och underklasserna Kund och Admin. Admin ska ha en specifik metod NollställSystem(). Visa hur en lista med Användare kan hanteras polymorft i ett fiktivt administrationsgränssnitt.

## Uppgift 8: Enkel Try-Catch (Division med noll)

Skapa ett program som ber användaren mata in två tal och dividerar dem. Kapsla in beräkningen i ett try-catch-block som fångar upp ett DivideByZeroException och ger användaren ett snyggt felmeddelande.

## Uppgift 9: Fånga generella undantag (FormatExceptions)

Skapa ett program som försöker konvertera en felaktig sträng till en int. Använd ett try-catch-block för att fånga upp FormatException. Lägg även till ett finally-block som skriver ut "Körningen avslutad".

## Uppgift 10: Kasta egna undantag (ArgumentException)

Skapa en klass Person med egenskapen Ålder. I set-accessorn ska du kontrollera om åldern är mindre än 0. Om den är det, kasta ett nytt ArgumentException med ett valfritt felmeddelande.

# Röda uppgifter (Egna undantagsklasser, Sammanhållning & Koppling)

_Avancerade koncept som introducerar egna undantag samt arkitekturprinciperna High Cohesion och Loose Coupling._

## Uppgift 11: Skapa en egen undantagsklass (SaldoSaknasException)

Skapa en egen undantagsklass som heter SaldoSaknasException genom att låta den ärva från basklassen Exception. Ge den en konstruktor som kan ta emot ett anpassat felmeddelande.

## Uppgift 12: Tillämpa det egna undantaget

Skapa en klass Bankkonto med metoden Uttag(double belopp). Om beloppet är större än saldot ska programmet kasta ditt egna SaldoSaknasException. Fånga upp detta specifika undantag i Main.

## Uppgift 13: Stark sammanhållning (High Cohesion)

Skapa en klass Rapport. Istället för att klassen både ska hämta data, formatera text och skriva ut på en skrivare, ge den _ett_ tydligt ansvar: att hålla rapportdata. Förklara principen om _Single Responsibility_.

## Uppgift 14: Lös koppling (Loose Coupling) via Interface

Skapa ett gränssnitt IMeddelandeTjänst med metoden Skicka(string text). Skapa klassen EpostTjänst som implementerar gränssnittet. Skapa sedan en klass Notifierare vars konstruktor tar emot ett IMeddelandeTjänst-objekt.

## Uppgift 15: Utmaning – Flexibel arkitektur vid lös koppling

Skapa ytterligare en klass SmsTjänst som implementerar IMeddelandeTjänst. Visa i Main hur enkelt det är att byta ut EpostTjänst mot SmsTjänst i din Notifierare utan att behöva ändra en enda rad kod inuti själva Notifierare-klassen.