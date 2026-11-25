# Arbeidslogg – Setereservasjon: Theory og grensetilfeller

## Før koding

Min forventning og begrunnelse:

Tenkte at programmet skulle godkjenne en reservasjon dersom antall ønskede seter var større enn 0 og det var nok ledige seter!

Tenkte og etter å ha sett på koden at testene skulle avsløre feilen i programmet, spessielt når antall ønskede seter var like antall ledige seter

## Forsøk

| Handling / testnavn                | Forventet              | Faktisk            | Hva lærte jeg?                                                       |
| ---------------------------------- | ---------------------- | ------------------ | -------------------------------------------------------------------- |
| Første testkjøring med 3 tilfeller | 3 bestått              | 2 besto, 1 feilet  | Testen med 4 ønskede og 4 ledige seter feilet.                       |
| La til 4 nye InlineData-rader      | 7 testtilfeller totalt | 7 tester ble kjørt | Lærte at Theory kan kjøre samme test med flere verdier.              |
| Testkjøring med 7 tilfeller        | 7 bestått              | 6 besto, 1 feilet  | Feilen oppstod fortsatt når ønskede og ledige seter var like.        |
| Endret operatoren fra < til <=     | 7 bestått              | 7 besto            | Programmet godkjente nå reservasjoner med nøyaktig nok ledige seter. |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

ExerciseTest.cs - la til fire ny InLineData-rader for å teste flere situasjoner
Seatpolic.cs - endret betingelsen fra < til <= sånn at reservasjonen også blir godkjent når antall ønskede seter er lik antall ledige seterrrr

Svar på refleksjonsspørsmålene:

Første testen som feilet var når 4 personer ønsket å reserve 4 ledige seter, programmet retunerte false selvom det skulle vært ok.
feilen ligger med operators <= / < som jeg nevnte i starten!

Etter endring kjørte jeg testene igjen og alle besto

lærte at theory & Inlinedata tillater for å teste flere forskjellige verdier med en testmetode, og at grenseverdier må alltids testest.
