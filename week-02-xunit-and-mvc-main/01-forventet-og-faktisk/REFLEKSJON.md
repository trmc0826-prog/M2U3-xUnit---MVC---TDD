# Arbeidslogg – Forsyninger: fra krav til testeksempler

## 1. Forventet og faktisk resultat

Fyll inn **Forventet** før du kjører programmet. Etter at du har kjørt alle fem tilfellene, fyller du inn **Faktisk** og om resultatene stemte.

| Inndata               | Forventet | Faktisk | Stemte det? |
| --------------------- | --------- | ------- | ----------- |
| 3 personer, 4 dager   | 24        | 24      | Ja          |
| 0 personer, 4 dager   | 0         | 0       | Ja          |
| 3 personer, 0 dager   | 0         | 0       | Ja          |
| 1 person, 1 dag       | 2         | 2       | Ja          |
| 20 personer, 30 dager | 1200      | 1200    | Ja          |

Hvordan fant du frem til de forventede resultatene?
brukte formelen antall personer x antall dager x 2.Hver person trenger 2 forsyningsenheter per dag. Ved å bruke denne formelen kunne jeg regne ut hva resultatet skulle være før jeg kjørte programmet.

## 2. Prøv å innføre en feil

Endre multiplikatoren fra 2 til 3, og kjør programmet på nytt.

**Hvilke tilfeller avslørte feilen?**

Tilfellene med 3 personer og 4 dager, 1 person og 1 dag, og 20 personer og 30 dager. Disse ga høyere resultater enn forventet da jeg endret multiplikatoren fra 2 til 3.

**Hvilke tilfeller ga fortsatt riktig resultat?**

Tilfellene med 0 personer og 4 dager, og 3 personer og 0 dager. Begge ga fortsatt resultatet 0. Er jo nesten litt "random" at disse tilfellene er rette.. Kontra andre tilfeller.

**Hvorfor kan nulltilfellene gi riktig resultat selv om multiplikatoren er feil?**
Fordi alt som multipliseres med 0 blir 0. Selv om vi endrer multiplikatoren til 3, vil resultatet fortsatt bli 0 dersom antall personer eller dager er 0. Derfor oppdaget ikke disse testene feilen.

// Husk å endre multiplikatoren tilbake til 2. den e god sjef

## 3. Refleksjon

Hvorfor er det ikke nok at programmet skriver ut et resultat for å avgjøre om en test består?

Fordi et program kan gjøre en matematisk riktig utregning, men fortsatt gi feil resultat i forhold til kravene. Da vi endret multiplikatoren til 3, regnet programmet riktig ut fra koden, men resultatet var feil fordi hver person egentlig bare skulle ha 2 forsyningsenheter per dag.

## 4. Endringer

Hvilke filer endret du, og hvorfor?

Program.cs: Jeg la til fire nye testtilfeller for å kontrollere at programmet ga riktige resultater med forskjellige antall personer og dager.

FuelCalculator.cs: Jeg endret multiplikatoren midlertidig fra 2 til 3 for å undersøke hvordan en feil påvirket resultatene. Etterpå endret jeg den tilbake til 2.
