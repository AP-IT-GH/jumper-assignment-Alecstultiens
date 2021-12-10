# Jumper Exercise - Funity

Aan de hand van deze tutorial zal u via meerdere stappen ons project kunnen volgen. 
Om dit project goed te kunnen laten draaien heb je Unity, Anaconda en de nieuwste versie van ML-Agents nodig.

## Spelverloop

Bij het starten van de applicatie zie je een donkerblauwe kubus, dit is George onze speler. Achterin zie je een witte muur die niet in het zicht staat bij het afspelen van het spel. Deze muur dient ervoor dat de abjecten die op de speler afkomen ook verdwijnen wanneer ze tegen deze muur botsen. Het is de bedoeling dat de speler zo vaak mogelijk over een object springt zonder het te raken. Dit gebeurt in een aantal stappen:
1. De speler kan springen door op de spatiebalk te drukken.
2. De objecten komen in verschillende intervallen af op de speler.
3. Per keer dat de speler over het object springt krijgt hij een extra punt.
4. De objecten elimineren zichzelf wanneer ze de wall of death bereiken.

## Observaties

De speler kan een object zien aankomen of kan niets zien aankomen. Er zijn dus 2 situaties die de speler kan observeren.

## Acties

De speler heeft de mogelijkheid om op de grond te staan of te springen. Er zijn dus 2 acties.

## Beloningsysteem

Telkens dat de speler over het object springt zonder dit te raken zal da speler beloont worden met + 1, Wanneer hij toch tegen het object botst zal de beloning -0.1 zijn. Omdat de speler in het begin vaak tegen de enemy botst zal deze dus veel impact hebben op. 

## Beschrijving Code

We hebben 3 scripts geschreven: Jumper, Spawner, KillOnHit en ScoreCounter. Deze scripts vindt je in Assets > Scripts.

#### Jumper

Dit script hebben we toegewezen aan de speler. Hierin zit ook ons beloningssysteem geïmplementeerd. De klasse waar het script in staat wordt overgeërfd van de klasse *agent*. Aan de hand van dit script kan de speler worden getraind.     

#### Spawner

Het script voor de spawner zorgt ervoor dat op willekeurige basis er auto's worden neergezet. Hierdoor krijgt de speler telkens een nieuwe auto in zijn visier. 

#### KillOnHit

Aan de hand van dit script worden de auto's die worden aangemaakt vernietigd. Een auto wordt vernietigd bij het raken van de muur die je achter de speler ziet staan. Zo blijven er geen overbodige instanties van de auto. 

#### ScoreCounter

Dit script bevat de logica om de score correct weer te geven en bij te houden.

## Componenten

#### Behavior Parameters

Deze component zorgt voor het gedrag van de *agent*. Hier kan je parameters invullen die invloed zullen hebben op hoe hard er wordt getraind en hoe er wordt getraind.

#### Scripts

De scripts zijn nodig om de game zo smooth mogelijk te laten verlopen. 

#### Ray Perception Sensor 3D

In dit project maken we gebruik van een ray perception. De ray perception zal worden getriggerd wanneer er objecten in ons geval auto's op de speler afkomen. Hierdoor kan de speler leren springen om de auto's te ontwijken.

## Configuratie

Stap 1: Clone project
> git clone https://github.com/AP-IT-GH/jumper-assignment-Alecstultiens.git

Stap 2: Add Project to Unity Hub 
> Druk op de knop ADD. Vervolgens selecteer je binnen het mapje *JumperExerice*. 

Stap 3: Project openen
> Het openen van dit project doe je door een versie aan te klikken. Hierna klik je door op de naam van het project. 

Stap 4: Scene openen 
> Wanneer het project is geopend, ga je naar Assets > Scenes. Hier zie je een scene staan genaamd *SampleScene*. Die klik je open.

Stap 5: Handmatig uittesten
> Bij player zie je een component staan *Behavior Parameters*. In deze component zie je een *behavior type* staan. Deze zet je op 
> *Heuristic Only*. Ten slotte klik je op play in het midden.

*Alec Stultiens* & *Quinten Onya* 