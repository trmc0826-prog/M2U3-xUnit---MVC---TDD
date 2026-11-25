# Arbeidslogg – Lastestabel: LIFO og forventede unntak

## Før koding

Min forventning og begrunnelse:

Egentlig veldig lite forventninger når jeg hoppet inn i denne, innbilte meg at det ble ganske likt som i oppgaven før. (4)

## Forsøk

| Handling / testnavn  | Forventet                 | Faktisk     | Hva lærte jeg?                         |
| -------------------- | ------------------------- | ----------- | -------------------------------------- |
| Pop på tom stabel    | InvalidOperationException | Feil unntak | Feilen måtte rettes i koden.           |
| Rettet CargoStack.cs | Testen består             | Besto       | Må sjekke om stabelen er tom først.    |
| LIFO med tekst       | B før A                   | Besto       | Siste inn kommer først ut.             |
| Test med int         | Returnerer 7              | Besto       | Generics fungerer med ulike datatyper. |
| Gjenbruk av stabel   | Kan brukes igjen          | Besto       | En tømt stabel kan brukes på nytt.     |
| Alle tester          | 4 bestått                 | 4 besto     | Alt fungerer som forventet.            |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

Cargostack.cs - la til en kontroll som sjekker at stabelen er tom før pop, prøver å hente et element. om den er tom kastest invalidoperationexception.

exercisetest.cs la til try nye fact-tester for å kontrollere lifo-rekkefølgen, bruk av heltall og gjenbruk av tom stabel. eksisterende testen kontrollerte og at count fortsatt er 0 etter unntaket.

Svar på refleksjonsspørsmålene:

1. Fordi kravet sier at tom stabel skal kaste invalidoperationexception. Om vi endrer testen til å godta argumentoutofrangeexception ville testen bestått selv om programmet ikke har oppfylt kravene. Rette feil i koden > ikke endre forventninger.

2. Assert.throws kontrollerer at vi kaster en bestemt type unntak. Assert.equal brukes til å sammenligne normale verdier som tall/tekst. her vil man kontrollere at riktig unntak oppstår når vi forsøker å hente noe fra tom stabel.

3. testene viser at vi kan bruke asmme klassen med forskjellige datatyper uten å måtte skrive ny klasse for hver type. <string> lagrer tekst og <int> lagrer heltall. begge bruker push/pop.
