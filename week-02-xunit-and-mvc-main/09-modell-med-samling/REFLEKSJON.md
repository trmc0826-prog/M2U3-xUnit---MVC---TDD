# Arbeidslogg – Oppdragstavlen: test modellen før menyen

## Før koding

Min forventning og begrunnelse:

forventet at de fleste skulle besto, men såg at det manglet en funksjon som brukte missionboard.complete(), tenkte disse da feilet siden metoden ikke var laget enda

## Forsøk

| Handling          | Forventet      | Faktisk           | Hva lærte jeg?                            |
| ----------------- | -------------- | ----------------- | ----------------------------------------- |
| Første test       | 1 feil         | 1 feilet          | Complete() var ikke implementert.         |
| La til 4 tester   | 8 totalt       | 6 besto, 2 feilet | Testet flere tilfeller.                   |
| Rettet Complete() | 8 bestått      | 8 besto           | Riktig oppdrag ble fullført.              |
| Testet GetAll()   | Samme objekter | Besto             | Listen er en kopi, objektene er de samme. |
| Siste test        | 8 bestått      | 8 besto           | Alt fungerte som forventet.               |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

exercisetests.cs - la til fire nye fact-tester for tom table, gjentatt fullføring, uavhengige tavler og assert.same()

missionboard.cs - implementerte complete(int id) med foreach for å finne rett oppdrag og kalle task.complete()

Svar på refleksjonsspørsmålene:

1. for å unngå å skrive samme funksjonalitet flere steder. missiontask vet allerede hvordan oppdraget fullføres, så missionboard trenger bare å finne rett oppdrag og kalle metoden.

2. beskytter interne listen mot at vi for eksempel tømmer den med clear(). oppdragene i listen er samme objekt, så endringene i disse objektene vil også påvirke oppdragene som tavlen lagrer.

3. assert.equal kontrollerer om verdiene er like.
   assert.same kontrollerer om to referanser peker til samme objekt.

4. sånn at testene er uavhengige. om alle deler samme tavle, kan en test endre innholdet og påvirke resultatet til de andre.
