# XUP - Xabal Universal Platform 3.0

La Piattaforma Universale Xabal nasce con lo scopo di fornire un'infrastruttura univoca e semplice da utilizzare in qualunque situazione, con qualunque dispositivo che abbia a disposizione una connessione ad una rete.

Per raggiungere questo obiettivo, la Piattaforma è formata da un componente "server-side" (nel progetto corrente è presente il componente server "xabal.php") e un componente "client-side" (nel progetto corrente sono presenti due Client, uno è "xabal.html", l'altro Client è in VB.NET, il cui progetto compilabile con Visual Studio 2010 è presente nella cartella "XabalTest").

Entriamo nel dettaglio:

# Server

Il Server di Xabal è un qualunque software in grado di ricevere ed elaborare chiamate POST.

In questo progetto il Server è stato programmato in PHP per la sua diffusione e versatilità, ma può essere programmato in qualunque linguaggio, infatti è importante definire che:

#### Xabal è un Modello, non un Software

Nel "Modello Xabal" il Server riceve una chiamata POST ed esegue la sanitizzazione di qualunque dato in ingresso.

Nella chiamata in ingresso deve essere presente il parametro "function"; tramite il parametro "function" il Server esegue la funzione oggetto della chiamata del Client.

