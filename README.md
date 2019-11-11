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

Dall'utilizzo dell'esempio online, si può notare come la chiamata POST sia inviata tramite del semplice Javascript.

La response delle varie funzioni è visualizzata a fondo pagina, in un "div" specifico con id "xabalresult".
  
Come è possibile osservare, la chiamata non genera nessun tipo di post-back e la pagina non ha bisogno di ricaricarsi, andando a creare l'esperienza di navigazione come presente in librerie o framework più complessi come Angular o React.

Si noti che, nel caso in cui la response sia un HTML, questo sarà renderizzato dal browser, proprio come i framework sopracitati.

Scaricando, invece, il sorgente in VB.NET si può notare come effettivamente il Codice sia ripetuto per ogni funzione, ed andrà a cambiare solo la stringa POST passata al Server.

Questo Modello, quindi, presenta molteplici vantaggi, tra i quali:

- Utilizzo dei Servizi da parte di qualunque software o dispositivo che supporta chiamate POST
- Possibilità di sviluppare di più, con meno codice
- E' possibile utilizzare i linguaggi già conosciuti
- Utilizzo delle risorse ridottissimo, rispetto ad altri tipi di Servizi Web.

Si menziona adesso, quindi, il concetto di "Nodo Xabal".

Un "Nodo Xabal" è un Server, e il Client sarà in grado di chiamare una funzione per eseguire una determinata operazione.

In questo progetto è presentato un Server in PHP in quanto moltissimi servizi di hosting hanno un piano di sottoscrizione gratuita.

Nel voler pensare anche al lato economico per lo sviluppatore che vuole approcciare tale Modello di Sviluppo, un hosting può incidere pesantemente a seconda delle necessità e delle esigenze.

Per ovviare a questo problema, il "Nodo Xabal" è stato programmato in PHP (e il Client in HTML sopra linkato riporta ad un hosting gratuito), in maniera tale da poter abbattere i costi di sviluppo di un'applicazione (anche complessa).

Molti servizi di hosting gratuiti, però, hanno delle limitazioni pesanti per quanto riguarda le operazioni o la velocità di esecuzione dei vari comandi.

Pertanto, la scelta del PHP serve anche a dotare lo sviluppatore di un vero e proprio "bilanciamento di carico".

Lo sviluppatore potrebbe decidere di caricare un Nodo su un hosting e un ulteriore Nodo su un altro hosting, di modo da avere sempre una ridondanza del proprio applicativo.

E' anche possibile per lo sviluppatore caricare due Server che eseguono operazioni differenti su due Server diversi, ed effettuare delle chiamate specifiche a seconda dell'operazione eseguita al momento dal Client.

Questo Modello, in pratica, può trasformare un applicativo in una struttura "Cloud-like" in poco tempo, abbattendo sia i costi di sviluppo, sia i costi dell'infrastruttura.

Un'ultima nota riguarda il perchè, per la trasmissione dei dati, si è scelta la chiamata POST pura e semplice.

Il perchè è presto detto.

In alcune situazioni non si hanno abbastanza risorse, banda o sistemi operativi che supportino dei Framework stratificati.

Proprio in queste situazioni è necessario trasmettere l'informazione nel minor numero di byte possibili.

Si pensi anche alle situazioni dove la connessione non è stabile ed è necessario trasmettere o elaborare informazioni in un tempo limitato.

La struttura di esempio riportata in questo progetto (e in generale il Modello Xabal), prevede dei componenti software molto semplici da reperire ed installare (è possibile installare uno stack LAMP, ovvero Apache + PHP + MySQL anche su un semplice Raspberry Pi).

Tali componenti non richiedono molte risorse (anche se dipende anche dall'applicazione) e hanno licenza libera (il tutto per rimanere in un'ottica di abbattimento dei costi).

Questo tipo di possibilità permette di ampliare il concetto di "Cloud" o "Edge Computing" come lo conosciamo in un qualcosa che potremmo definire come un "AnyCloud" (è possibile ad esempio installare un server PHP anche su un telefono Android da 100 €) ovvero "tutto può far parte della Rete dei Nodi Xabal", andando concettualmente ad ampliare all'infinito le attuali possibilità di calcolo e distribuzione delle informazioni.

Per spiegare meglio il concetto, prenderò come esempio due situazioni estreme.

La prima è in una situazione di guerra.

Si potrebbero progettare delle "tute intelligenti" (o "rendere intelligenti" le attuali), ognuna con il proprio Raspberry equipaggiato, che può sia elaborare e trasmettere dati, sia riceverne per avvisare ad esempio di una situazione di pericolo.

Si pensi, inoltre, ad una eventuale calamità.

