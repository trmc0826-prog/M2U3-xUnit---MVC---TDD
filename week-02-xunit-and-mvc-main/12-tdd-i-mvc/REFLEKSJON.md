# Arbeidslogg – Nytt behov: vis bare ufullførte oppdrag

## Før koding

Min forventning og begrunnelse:

Forventer å få litt skallebank av denne(: mye å holde styr på. // fikk skallebank

Ser at noen tester kommer til å feile siden vi mangler getpending

målet er vell å vise ufullførte oppdrag

## Forsøk

| Handling      | Forventet       | Faktisk       | Hva lærte jeg?                  |
| ------------- | --------------- | ------------- | ------------------------------- |
| Red           | 1 feil          | 1 feilet      | GetPending fungerte ikke ennå.  |
| La til tester | 7 totalt        | 2 feilet      | Testet flere tilfeller.         |
| Green         | 7 bestått       | 7 besto       | Filtreringen fungerte.          |
| Flere tester  | 10 bestått      | 10 besto      | Testet rekkefølge og listekopi. |
| Refactor      | Vurdere koden   | Ingen endring | Koden var enkel.                |
| Menyvalg 4    | Vise ufullførte | Fungerte      | MVC-delene samarbeidet.         |
| Konsolltest   | 11 steg         | Alle fungerte | Oppdragene ble ikke slettet.    |
| Siste tester  | 10 bestått      | 10 besto      | Alt fungerte fortsatt.          |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

missionboard.cs - implementerte getpending() sånn at den returnerer en ny liste med bare ufullførte oppdrag.

exercisetests.cs laget fem nye Fact-tester for: tom tavler, alle ufullførte, alle fullførte, riktig rekkefølge og listekopi.

missionview.cs - la til menyvalg "4" - Vis ufullførte

missioncontroller.cs - koblet til menyvalg 4 til \_board.getpending og view.showtasks.

Svar på refleksjonsspørsmålene:

1.eeeh er jo litt som tidligere - denne modellen som har ansvar for å gjøre disse oppdragene og bestemme hvilke som ikke er fullførte.

2. fullførte oppdragene fortsatt skal finnes på tavlen. Den nye listen gjør at vi kan vise bare ufullførte.
   nye listen gjør at vi kan vise bare de ufullførte oppdragene. // vi sletter/endrer da heller ikke the original data

3. Metoden returnerte allerede en tom liste. når tavlen faktisk var tom ble resultatet riktig selv om metoden ikke funker for tavler med oppdrag

4. fordi showtasks() allerede viser både tomme og fylte lister. Kontrolleren kan derfor bare sende den filtrerte listen fra getpending() til den eksisterende metoden.

5. Eksisterende testene kontrollerer at tavlen fortsatt kan legge til, vise og fullføre oppdrag. etter alle testene fortsatt besto etter endringene, vil det si at den tidligere funksjonaliteten fortsatt funka for de testa tilfellene.
