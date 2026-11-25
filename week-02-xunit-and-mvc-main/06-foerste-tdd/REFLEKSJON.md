# Arbeidslogg – Oppdragskort: første Red–Green–Refactor

## Før koding

Såg at første testen sklle bestå siden den ikke kontrollerte at et nytt oppdrag startet som ufullført.

Såg ikke like grunndig gjennom resten

## Forsøk

| Handling            | Forventet         | Faktisk       | Hva lærte jeg?               |
| ------------------- | ----------------- | ------------- | ---------------------------- |
| Starttest           | Bestått           | 1 besto       | Starttilstanden var riktig.  |
| Red                 | Testen feiler     | 1 feilet      | Funksjonaliteten manglet.    |
| Green               | Testene består    | 2 besto       | Complete() fungerer.         |
| Gjentatt Complete() | Fortsatt fullført | 3 besto       | Id og Title ble ikke endret. |
| Refactor            | Vurdere koden     | Ingen endring | Koden var allerede enkel.    |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

EXerciseTests.cs - jeg skrev to nye fact-tester for å kontrollere fullføring og gjentatt fullføring.

Missionstasks.cs implementerte complete() slik at IsCompleted.

Svar på refleksjonsspørsmålene:

1. For å bestemme hvordan funksjonaliteten skulle funke før koden ble skrevet. kunne deretter bruke testen til i å kontrollere at implementasjonen ble riktig.

2. fordi det viste at testen faktisk oppdaget at funksjonaliteten mangla. Skrev complete(), kunne se at testen gikk fra rød til grønn.

3. fordi vi endrer hva programmet gjør, før gjorde complete() ingenting, men etter endringen setter den iscompleted til true - refaktoreringen skal ikke endre funksjonaliteten.

4. koden kan allerede være enkel og tydelig. oppgaven her var complete() bare en linje, så visste ikke hvordan jeg kunne gjøre den "bedre" / eller mindre.
