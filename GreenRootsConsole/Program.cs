// Definer produkt data
int navnKolloneBredde = 24;
// Produkt 1
int produkt1Id = 1;
string produkt1Navn = "Bambus tandbørste".PadRight(navnKolloneBredde).Substring(0, navnKolloneBredde);
string produkt1Kategori = "Bad";
double produkt1Pris = 39.0;
string produkt1Miljømærke = "Svanemærket";
int produkt1AntalSolgt = 243;
// Produkt 2
int produkt2Id = 2;
string produkt2Navn = "Genanvendelig kaffefilter".PadRight(navnKolloneBredde).Substring(0, navnKolloneBredde);
string produkt2Kategori = "Køkken";
double produkt2Pris = 129.0;
string produkt2Miljømærke = "Ingen";
int produkt2AntalSolgt = 214;
// Produkt 3
int produkt3Id = 3;
string produkt3Navn = "Lounge Sofa".PadRight(navnKolloneBredde).Substring(0, navnKolloneBredde);
string produkt3Kategori = "Have";
double produkt3Pris = 12999.0;
string produkt3Miljømærke = "Ingen";
int produkt3AntalSolgt = 16;
// Produkt 4
int produkt4Id = 4;
string produkt4Navn = "Royal Canin Hundemad".PadRight(navnKolloneBredde).Substring(0, navnKolloneBredde);
string produkt4Kategori = "Dyreartiker";
double produkt4Pris = 799.0;
string produkt4Miljømærke = "Ingen";
int produkt4AntalSolgt = 32;
// Produkt 5
int produkt5Id = 5;
string produkt5Navn = "Badebasin".PadRight(navnKolloneBredde).Substring(0, navnKolloneBredde);
string produkt5Kategori = "Fritid";
double produkt5Pris = 245.95;
string produkt5Miljømærke = "Ingen";
int produkt5AntalSolgt = 3201;
// PadRigth reservere plads (tilføjer mellemrum) 
// Substring indsætter produktnavn op til 24 bogstaver og sætter længst til venstre. De ikke brugte pladser bliver til tomme pladser. 
// Det gøres for at det visuelt er nemmere at læse consol udskrift. 

//2: Implementer en metode, der beregner omsætning for hvert produkt ved hjælp af simple matematiske operationer og selection statements:
double BeregnOmsætning(double pris, int antalSolgt)
{
    return pris * antalSolgt;
}

// 3.Implementer en metode, der kategoriserer produkter efter omsætning ved hjælp af if/else statements:
string KategoriserOmsætning(double omsætning)
{
    int typeKolloneBredde = 16;

    // Implementeres med if/else statements
    if (omsætning < 10000)
    {
        // "Lav omsætning": Under 10.000 kr.
        return "Lav omsætning".PadRight(typeKolloneBredde).Substring(0, typeKolloneBredde);
    }
    else if (omsætning < 50000)
    {
        // "Mellem omsætning": 10.000-50.000 kr.
        return "Mellem omsætning".PadRight(typeKolloneBredde).Substring(0, typeKolloneBredde);
    }

    // "Høj omsætning": Over 50.000 kr.
    return "Høj omsætning".PadRight(typeKolloneBredde).Substring(0, typeKolloneBredde);
}

//4: Brug en for-løkke til at simulere indlæsning og behandling af data for et variabelt antal dage:
int antalDage = 7;
double totalOmsætning = 0;
// Iterer dage
for (int dagNr = 1; dagNr <= antalDage; dagNr++)
{
    Console.WriteLine($"\nDag: {dagNr}");
    double dagsOmsætning = 0;

    // Simuler varierende dagligt salg ved hjælp af dagsnummeret
    int produkt1DagligtSalg = produkt1AntalSolgt / antalDage + (dagNr % 3);
    int produkt2DagligtSalg = produkt2AntalSolgt / antalDage + (dagNr % 3);
    int produkt3DagligtSalg = produkt3AntalSolgt / antalDage + (dagNr % 3);
    int produkt4DagligtSalg = produkt4AntalSolgt / antalDage + (dagNr % 3);
    int produkt5DagligtSalg = produkt5AntalSolgt / antalDage + (dagNr % 3);

    // Beregn dagens omsætning
    // Tilføj til totalOmsætning
    double produkt1Omsætning = BeregnOmsætning(produkt1Pris, produkt1DagligtSalg);
    string produkt1Type = KategoriserOmsætning(produkt1Omsætning);
    double produkt2Omsætning = BeregnOmsætning(produkt2Pris, produkt2DagligtSalg);
    string produkt2Type = KategoriserOmsætning(produkt2Omsætning);
    double produkt3Omsætning = BeregnOmsætning(produkt3Pris, produkt3DagligtSalg);
    string produkt3Type = KategoriserOmsætning(produkt3Omsætning);
    double produkt4Omsætning = BeregnOmsætning(produkt4Pris, produkt4DagligtSalg);
    string produkt4Type = KategoriserOmsætning(produkt4Omsætning);
    double produkt5Omsætning = BeregnOmsætning(produkt5Pris, produkt5DagligtSalg);
    string produkt5Type = KategoriserOmsætning(produkt5Omsætning);

    // Beregn dags omsætning
    dagsOmsætning += produkt1Omsætning;
    dagsOmsætning += produkt2Omsætning;
    dagsOmsætning += produkt3Omsætning;
    dagsOmsætning += produkt4Omsætning;
    dagsOmsætning += produkt5Omsætning;
    // Læg til total omsætning
    totalOmsætning += dagsOmsætning;

    // Udskriv dagens statistik
    Console.WriteLine($"Id: {produkt1Id}: {produkt1Navn} - type {produkt1Type} - omsætning: {produkt1Omsætning:N2} kr ");
    Console.WriteLine($"Id: {produkt2Id}: {produkt2Navn} - type {produkt2Type} - omsætning: {produkt2Omsætning:N2} kr");
    Console.WriteLine($"Id: {produkt3Id}: {produkt3Navn} - type {produkt3Type} - omsætning: {produkt3Omsætning:N2} kr");
    Console.WriteLine($"Id: {produkt4Id}: {produkt4Navn} - type {produkt4Type} - omsætning: {produkt4Omsætning:N2} kr");
    Console.WriteLine($"Id: {produkt5Id}: {produkt5Navn} - type {produkt5Type} - omsætning: {produkt5Omsætning:N2} kr");
    Console.WriteLine($"Dagsomsætning {dagsOmsætning:N2} kr");
}

Console.WriteLine($"\nTotal omsætning: {totalOmsætning:N2} kr");
//N2 gør at kun 2 decimaler udskrives 