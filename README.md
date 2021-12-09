# Jumper Exercise (Funity)

Aan de hand van deze tutorial zal u via meerdere stappen ons project kunnen volgen. 
Om dit project goed te kunnen laten draaien heb je Unity, Anaconda en de nieuwste versie van ML-Agents nodig.

# Spelverloop

Bij het starten van de applicatie zie je een donkerblauwe kubus, dit is George onze speler. Achterin zie je een witte muur die niet in het zicht staat bij het afspelen van het spel. Deze muur dient ervoor dat de abjecten die op de speler afkomen ook verdwijnen wanneer ze tegen deze muur botsen. Het is de bedoeling dat de speler zo vaak mogelijk over een object springt zonder het te raken. Dit gebeurt in een aantal stappen:
1. De speler kan springen door op de spatiebalk te drukken.
2. De objecten komen in verschillende intervallen af op de speler.
3. Per keer dat de speler over het object springt krijgt hij een extra punt.
4. De objecten elimineren zichzelf wanneer ze de wall of death bereiken.

# Observaties

De speler kan een object zien aankomen of kan niets zien aankomen. Er zijn dus 2 situaties die de speler kan observeren.

# Acties

De speler heeft de mogelijkheid om op de grond te staan of te springen. Er zijn dus 2 acties.

# Beloningsysteem

Telkens dat de speler over het object springt zonder dit te raken zal da speler beloont worden met + 1, Wanneer hij toch tegen het object botst zal de beloning -0.1 zijn. Omdat de speler in het begin vaak tegen de enemy botst zal deze dus veel impact hebben op. 

# Ray Perception

Er is 1 maar 1 ray nodig. Aangezien de speler enkel objecten van voor zich ziet afkomen is er maar 1 ray nodig en deze wordt getriggerd wanneer er een object op hem afkomt.

Aanvullen en tekst verbeteren

# Beschrijving Code

# Componenten

# Configuratie


