# Arbeidslogg – Visningen: vis data uten å endre dem

## Før koding

Min forventning og begrunnelse:

Forventet at fire modelltestene skulle bestå, men at konsollprogrammet ikke ville vise oppdragene siden showtasks() ikke er med.

målet var oppdragene og status. uten å endre modellstrukturen.

## Forsøk

Handling / testnavn | Forventet | Faktisk | Hva lærte jeg?
---|---|---|---

## Etterpå

Hvilke filer endret jeg, og hvorfor?

missionviews.cs - implementerte showtasks() med if, foreach og consolewritelines for å vise oppdrag og status.

Svar på refleksjonsspørsmålene:

1. Fordi modelltestene kontrollerer at modellene funker, men ikke hva som blir skrevet ut i konsollen = testene kan bestå selv om visningen mangler eller viser feil informasjon.

2. fordi visningen bare skal presentere informasjon til brukeren. om den og endrer på oppdraget kan det føre til uventede endringer + vi skal bare se dem.

3. oppdragene ligger allerede i modellen. Ved å sende listen til showtasks kan visningen vise info uten å måtte oprette en ny tavle eller håndtere oppdragene selv.

4. fordi view bestemmer hvordan informasjonen skal vises og er ansvarlig for det.
   modellen bestemmer og lagrer om oppdraget er fullført, altså at de har vært sitt ansvar/funksjon.

