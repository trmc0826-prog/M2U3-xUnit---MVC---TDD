# Arbeidslogg – Lasterom: test tilstand uten testrekkefølge

## Før koding

Min forventning og begrunnelse:

tenkte at lasterom skulle være tom, og at vi måtte legge inn maksimalt to enheter, hvis jeg prøvde å legge inn en tredje enhet - skulle programmet avvise det uten å endre antall enheter i lasterommet

Forventet at to forskjellige lasterom skulle fungere uavhengig av hverandre, og at hver test må kunnest kjørest aleeeine.

## Forsøk

| Handling / testnavn                | Forventet         | Faktisk           | Hva lærte jeg?                                                  |
| ---------------------------------- | ----------------- | ----------------- | --------------------------------------------------------------- |
| Constructor_StartsEmpty            | Count = 0         | Count = 0         | Et nytt lasterom starter tomt.                                  |
| TryAdd_FirstItem_ReturnsTrue       | true, Count = 1   | true, Count = 1   | Første innlegging lykkes.                                       |
| TryAdd_SecondItem_ReturnsTrue      | true, Count = 2   | true, Count = 2   | Andre innlegging lykkes når den første allerede er lagt inn.    |
| TryAdd_ThirdItem_ReturnsFalse      | false, Count = 2  | false, Count = 2  | Et fullt lasterom avviser flere enheter uten å endre innholdet. |
| TwoCargoBays_HaveIndependentCounts | bay = 1, bay2 = 0 | bay = 1, bay2 = 0 | To forskjellige objekter har uavhengig tilstand.                |
| Kjørte én test med --filter        | 1 test bestått    | 1 besto           | En test kan kjøres alene uten de andre.                         |
| Kjørte alle testene på nytt        | 5 tester bestått  | 5 besto, 0 feilet | Alle testene fungerer sammen og uavhengig.                      |

## Etterpå

Hvilke filer endret jeg, og hvorfor?

exercisetests.cs la til fyre nye fact-tester for å kontrollere inlegging - og at to forskjellige lasterom har uavhengig innhold.

trengte ikke cargobay.cs siden alt som lå der gjorde at vi kunne gjøre oppgaven

Svar på refleksjonsspørsmålene:

1. fordi hver test skal være uavhengig av de andre. testen må fyllelasterommet med to enheter før den prøver å legge inn en tredje, ellers ville testen vært avhengig av at andre tester kjørte først.
   2.returverdi forteller oss om det blir godkjent eller avvist. Count viser hvor mange enheter som faktisk liggeri lasterommet.
   mulig at metode retunere false, men må selvom endre innholdet på grunn av en feil, derfor burde vi kontrollere begge.
2. om alle testene bruker samme objekt, kan en test påvirke resultatet til en annen.Et lasterom kan være fullt fra tidligere test som gjør at neste ikke starter med tomt lasterom. Da vil resultatene variere fra hvilken rekkefølge/prioritet vi kjører de. Nytt objekt == unngå dette
