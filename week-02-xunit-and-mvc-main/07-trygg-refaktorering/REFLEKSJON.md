# Arbeidslogg – Oppskytingspris: forbedre grønn kode

## Før koding

eg forventet at prisberegningen allerede fungerte, men at koden kunne gjøres enklere og mer oversiktlig. Målet var å forbedre koden uten å endre resultatene.

Jeg forventet også at testene skulle oppdage feil dersom jeg endret prisberegningen.

## Forsøk

| Handling         | Forventet   | Faktisk  | Hva lærte jeg?            |
| ---------------- | ----------- | -------- | ------------------------- |
| Første test      | 5 bestått   | 5 besto  | Koden fungerte.           |
| La til tester    | 7 bestått   | 7 besto  | Testet maks 20 personer.  |
| Endret navn      | 7 bestått   | 7 besto  | Koden ble lettere å lese. |
| Forenklet kode   | 7 bestått   | 7 besto  | Fjernet gjentakelser.     |
| Endret 20 til 21 | Noen feiler | 3 feilet | Testene fant prisfeilen.  |
| Rettet tilbake   | 7 bestått   | 7 besto  | Alt fungerte igjen.       |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

ExerciseTests.cs: Jeg la til to nye InlineData-rader for å teste 20 personer med og uten prioritet.

LaunchPrice.cs: Jeg endret variabelnavnene fra n, p og x til peopleCount, priority og totalPrice. Jeg fjernet også den gjentatte beregningen og den unødvendige else-delen.

Svar på refleksjonsspørsmålene:

1. Koden ble lettere å lese fordi variablene sine navn naturlig forklarte hva de representerte og gjorde.

2. For å kontrollere at koden fortsatt funker etter hver endring. om en test har feil, ville det vært lettere å finne ut hvilken endring som stod bak feilen.

3. å forbedre beregningen betyr å gjøre koden enklere uten å endre resultat.. å endre prisregelen betyr at selve prisen blir annderledes, som når vi endret den fra 20 til 21.

4. nei, fordi testene bare kontrollere tilfenne vi har skrevet testet for. det kan fortsatt finnes feil i situasjoner som ikke er testet.
