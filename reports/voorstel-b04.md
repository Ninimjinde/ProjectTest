# PBL TimeRegistration project

## Voor wie?

Klanten die moeten factureren naar hun klanten en hier ook uren werk ingeven in de factuur. Denk aan electricien, bouwbedrijf, IT'ers,...

## Hoe werkt het?

We werken een app uit die ervoor zorgt dat je je uren kan registreren wanneer je aan het werken bent aan 1 project.

## Uiterlijk en kleuren

Hierover zal nog gebrainstormd worden, misschien hier de keuze geven om een nacht en dagthema te kiezen en hierop de kleuren af te stellen.

### Voorbeeld
Bouwbedrijf gaat een lekkage gaan herstellen bij een klant en wil weten hoe lang de arbeider hieraan bezig was. De arbeider kan hier zijn app gebruiken en wanneer hij op de plaats komt, de plaats ingeven door 'locatievoorziening' aan te spreken of gewoon het project invoeren. Hij drukt op 'start', voert de werken uit en drukt op 'stop' wanneer de werken zijn uitgevoerd.

Deze worden dan doorgestuurd naar het programma waar de facturatie gedaan wordt, in ons geval 'Business Central'. Hierdoor krijgen ze een goed zicht op wie welke werken uitvoert en hoe lang ze hieraan gewerkt hebben.

Je kan ook een optie invoeren dat men met vaste tijden werkt. Je kan dan in de instellingen ingeven welke uren je werkt, pauzes ingeven, werkdagen selecteren. Hier geef je dan gewoon aan wanneer je een nieuw project start en stopt. Pauzes moet je niet ingeven, die worden automatisch ingecalculeerd door het programma.

## Pagina's

### *Eerste pagina/Login* 

De app opent met een log in scherm. Je kan hier kiezen om in te loggen met vingerafdruk of als je het voor het eerst gebruikt/indien vingerafdruk niet gewenst is, je kan inloggen met naam en paswoord. (api gebruiker)

### *Projectpagina*

Hier kun je je project kiezen (api project). De datum wordt opgehaald van de gsm als werkdatum (api?). Er is een start en stop knop en een timer die loopt, 
ook nog een veld met een log van gedane werken. 
Je kan ook foto's toevoegen en meer info opvragen over het project. 
We kunnen dit eventueel ook achter een knop steken naar een andere pagina, wat misschien beter is.

### *Infopagina*

Hier kun je meer info vinden over het project en vragen stellen.

### *Configuratiepagina*

Hier kun je alle instellingen van je app wijzigen. 
Je kan kiezen of je met variabele tijden werkt of vaste tijden. 
Indien vaste tijden kun je ingeven welkde deze zijn (dagen niet vergeten) en aangeven wanneer de pauzes en einde van de dag is. 
Je kan ook kiezen of je de pauzes of einde van de dag wil aangeven door een alarm op de gsm, bvb 10 minuten voor tijd als je materiaal moet opruimen. 
Een IT'er kan misschien ook een link maken met de agenda, wanneer hij meeting heeft ofzo. Moet dit uitzoeken of dit mogelijk is en niet te uitgebreid is.
De taal kan gekozen worden ook.

### *Admin pagina*

Hier kan de admin users aanmaken of verwijderen. 
De admin maakt ook de projecten/tickets aan. Zo kan de gebruiker kiezen welk project hij of zij aan werkt. 
Kan misschien ook een optie bedenken waar de admin de projecten kan toewijzen aan een gebruiker ook, maar dit is enkel een bedenking.
De admin kan ook dringende berichten sturen naar een gebruiker die dan opkomen als popup bericht.

## Native app functies
Hier dacht ik aan een vingerafdrukherkenning bij het openen van de app zodat de identiteit van de gebruiker meteen is gekoppeld. 

Alarmen kunnen gebruikt worden om pauzes aan te kondigen of einde werkdag. 

Locatievoorziening kun je bvb gebruiken als je op locatie gaat en niet weet waar je moet zijn (de plaats wordt doorgegeven door de opdracht) of je weet de naam niet van de klant en je geeft de plaats gewoon zo in. 

Foto's kunnen genomen worden van de werkplaats om defecten of uitgevoerde werken aan te duiden. Ik denk bvb aan 'voor' en 'na' foto als het over bouwwerken gaat. Dit kan handig zijn om in een map van het project te bewaren om later bvb als portfolio te gebruiken ook. 

## Extra eigenschappen

De app update de gegevens elke x aantal minuten naar de database. Het is namelijk heel makkelijk dan om aan het kantoor te laten weten met welk project je bezig bent, of je op kantoor of locatie bent, of je bereikbaar bent enz... Zo wordt ook gelogd hoeveel uren je bezig was aan een project en verloopt de facturatie makkelijker. De gehele map (uren, opmerkingen, foto's) wordt gelogd en kan op elk moment geraadpleegd worden door de bevoegde personen. Zo is er meteen ook nooit discussie, wie aan welk project gewerkt heeft indien er een jaar later een fout opduikt of misschien verder moet gewerkt worden aan iets. Op een bouwproject kun je het zien als een commit/push van je werk op bepaalde momenten.

De gebruikers worden aangemaakt door de admin, je kan jezelf niet registreren. Zo beveilig je de app ook tegen ongewenste gebruikers. De werknemers krijgen user en paswoord gemaild of in bericht, kan door bedrijf zelf beslist worden.
