# Arbeidslogg – Skill oppskytingsregelen fra konsollen

## Før koding

tenkte noen tester kom til å feile pga launchpolicy ikke hadde implementert oppskytningsregelen
målet var å flytte regelen fra program.cs til launchpolicy.cs så vi kan teste uten å kjøre hele programmet

## Forsøk

| Handling            | Forventet      | Faktisk           | Hva lærte jeg?            |
| ------------------- | -------------- | ----------------- | ------------------------- |
| Første test         | 1 feil         | 1 feilet          | Regelen manglet.          |
| La til 3 tester     | 5 totalt       | 2 feilet, 3 besto | Testet flere tilfeller.   |
| Rettet LaunchPolicy | 5 bestått      | 5 besto           | Regelen fungerte.         |
| Endret Program.cs   | Bruke modellen | Endret            | Unngikk dobbel kode.      |
| Testet konsollen    | 3 riktige svar | 3 riktige         | Hele programmet fungerte. |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

exercisetests.cs - la til tre nye inlinedata-rader for å teste kombinasjoner av drivstoff og sikkerthetsgodkjenning

launchpolicy.cs - implenterte regelen sånn at oppskyting bare tillates når drivstoffet er minst 50 og sikkerheten er godkjent

program.cs - erstattet den oprinnelige betingelsen med et kall til launch.policy.canlaunch().

Svar på refleksjonsspørsmålene:

1. fordi vi kan taste inn verdier i testen og kontrollere resultatet uten å måtte skrive inn noe manuelt i konsollen

2. blir enklere å vedlikeholde koden. om regelen skal endrest er det bare ett sted å endre.

3. enhetstesten sjekker launchpolicy.canlaunch() retunerer riktig verdier.
   når konsollprogrammet kjørest kontrollerer vi at programmet tar imot brukerinput, bruker modellene og skriver ut riktig mælding.

4. Er ikke nok å organisere filer i mapper om koden fortsatt gjør flere forskjellige oppgaver samtidig. må skille ansvaret i selve koden, sånn at modellen håndterer reglene og konsollprogrammet håndterer input.
