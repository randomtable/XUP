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

Nella chiamata, se necessario, saranno presenti altri parametri utili per la corretta elaborazione della funzione.

Una volta eseguita la funzione, il Server deve restituire il risultato al Client (dal momento che in questo progetto il Server è stato programmato in PHP, la response verrà inviata dal Server tramite il comando "echo").

E' possibile visualizzare nei sorgenti come è stato sviluppato il tutto.

# Client

Dal momento che il Client può essere sviluppato in qualunque linguaggio che supporti chiamate POST, si è deciso di svilupparne di due tipi.

Il primo in HTML+Javascript, mentre il secondo in VB.NET

Questo tipo di scelta è dettata dalle infinite possibilità di questo Modello e dai tipi di approcci che possono essere presi.

Il Client HTML+Javascript è presente online qui:

https://loremitalia.altervista.org/xabal.html

Un esempio di Server è presente qui:

https://loremitalia.altervista.org/xabal.php

Dall'utilizzo dell'esempio online, si può notare come la chiamata POST sia inviata tramite del semplice Javascript, ed è sufficiente cambiare 

Scaricando, invece, il sorgente in VB.NET si può notare come effettivamente il Codice sia ripetuto per ogni funzione, ed andrà a cambiare solo la stringa POSt passata al Server.
