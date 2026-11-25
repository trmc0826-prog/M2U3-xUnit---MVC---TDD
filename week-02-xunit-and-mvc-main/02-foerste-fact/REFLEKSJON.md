# Arbeidslogg – Første xUnit-test og Arrange–Act–Assert

## Før koding

Min forventning og begrunnelse:

Tenkte at xUnit ville teste beregningene automatisk, i stedet for å eg måtte sammenligne resultatene manuelt som i oppgave 1.
såg/tenkte også at testene ville feile hvor de feilet og rett hvorav de var rett

## Forsøk

| Handling / testnavn                      | Forventet                                  | Faktisk           | Hva lærte jeg?                                                |
| ---------------------------------------- | ------------------------------------------ | ----------------- | ------------------------------------------------------------- |
| Calculate_ThreeCrewForFourDays_Returns24 | 24                                         | 24                | Den opprinnelige testen besto.                                |
| Calculate_ZeroCrewFourDays_Returns0      | 0                                          | 0                 | Lærte å lage en egen test med Arrange, Act og Assert.         |
| Calculate_OneCrewOneDay_Returns2         | 2                                          | 2                 | Lærte at hver test må ha [Fact] for å bli gjenkjent av xUnit. |
| Endret multiplikatoren fra 2 til 3       | 3 tester skulle bestå med riktig beregning | 2 feilet, 1 besto | xUnit oppdaget automatisk feil i beregningene.                |
| Endret multiplikatoren tilbake til 2     | 3 tester skulle bestå                      | 3 besto           | Bekreftet at testene besto igjen etter at feilen ble rettet.  |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

ExerciseTests.cs: Jeg la til to nye tester med [Fact] og brukte Arrange–Act–Assert for å kontrollere beregningene.

FuelCalculator.cs: Jeg endret multiplikatoren midlertidig fra 2 til 3 for å introdusere en feil, og endret den tilbake til 2 etterpå.

Svar på refleksjonsspørsmålene:
