# Arbeidslogg – Kontrolleren: koble sammen en hel konsollapp

## Før koding

Min forventning og begrunnelse:

Forventer å bli litt overwhelmed av denne, haha masse å lese og forstå fra forskjellige .cs filer og hvordan de kommuniserer sammen, samt å følge alle stegene mot slutten iforhold til "riktig" test prosedyre.

Målet er å koble sammen model, view og controller sånn at brukeren kan legge til, vise og fullføre oppdrag via konsoll. me thinks.

## Forsøk

| Handling / testnavn | Forventet | Faktisk | Hva lærte jeg? |
| ------------------- | --------- | ------- | -------------- |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

MissionController.cs - implementerte completetask() sånn at den leser inn ID. bruker int.tryparse() for å kontrollere input, kaller modellen og viser riktig melding via view.

endret vell bare den i denne oppgaven

1. sånn att oppdragene beholdes mellom menyvalgene. ellers blir det ny tavle hver gang og da forsvinner tidligere oppdrag.

2. sånn at brukeren kan skrive inn tekst, mens complete() trenger et helltal. TryParse sjekker at teksten kan gjøres om til et tall uten at programmet krasjer ved feil input

3. dette er modellens ansvar, kontrolloren skal bare sende id-en til modellen og bruke resultatet til å bestmme hvilken melding som vises.

4. fordi at modelltestene bare kontrollerer modellen. Menyen blir ikke testet. Om selvfølgelig de er koblet sammen riktig.

5. View leser ID-en fra brukeren / sender teksten til controller / controller bruker tryparse, omgjør til heltall og kaller missionboard.complete(id).

   model finner oppdrag, endrer status om den fins. sender model resultat tilbake til controller, view viser riktig melding.

   flyten er: View -> Controller -> Model -> Controller ->
