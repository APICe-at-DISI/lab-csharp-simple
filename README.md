# Programmazione a oggetti - Lab C-Sharp

L'ordine degli esercizi sarebbe il seguente:

1. `Properties`
2. `ComplexAlgebra`
3. `Calculus`
4. `Arrays`
5. `Iterators`
6. `Indexers`

Svolgere gli esercizi in ordine diverso non è un problema, a patto che `Calculus` ed `Arrays` vengano entrambi svolti dopo `ComplexAlgebra`

Nota generale per tutti gli esercizi: lo statement `throw new NotImplementedException();` è un segnaposto che va sempre **sostituito** con del codice prodotto da voi.

## Esercizio 1 - Proprietà

Il progetto `Properties` consiste in un semplice programma a riga di comando che permette di generare un mazzo di carte (deck) a partire dai nomi dei semi (p.e. fiori, quadri, picche e cuori) e dai nomi delle carte (p.e. asso, ..., fante, regina, re).

La classe `Program` rappresenta il punto d'ingresso dell'applicazione e, come esempio, genera un mazzo di carte italiane.
La classe `DeckFactory` permette di costruire un certo numero di istanze della classe `Card` (che andranno a comporre il mazzo) a partire dai nomi dei semi e delle carte.
Queste classi sono state scritte da un programmatore Java, non abituato a scrivere codice C-Sharp.

Scopo dell'esercizio è "convertire" il codice dallo stile Java allo stile C-Sharp, ad esempio usando le proprietà e gli altri costrutti tipici del secondo linguaggio.

Notare anche che nel codice vengono impiegate sia le stringhe formato (alcuni esempi qui: https://msdn.microsoft.com/it-it/library/system.string.format(v=vs.110).aspx) che l'interpolazione di stringhe (alcuni esempi: https://docs.microsoft.com/it-it/dotnet/csharp/language-reference/keywords/interpolated-strings).
La comprensione di questi aspetti del linguaggio è auspicabile.

## Esercizio 2 - Algebra Complessa

Il progetto `ComplexAlgebra` prevede l'implementazione di una classe per rappresentare i numeri complessi.
Questa verrà utilizzata nell'esercizio corrente, così come pure in `3-Calculus` e `4-Arrays` (prova ne sia che questi progetti dipendono da `2-ComplexAlgebra`).

La classe `Program` rappresenta il punto d'ingresso dell'applicazione e, come esempio, genera alcuni numeri complessi e ne visualizza le proprietà costituenti.

Scopo dell'esercizio è imparare a modellare una struttura dati immutabile e priva di stato in termini di proprietà e metodi, e implementarla per mezzo delle classi di .NET.
In particolare, lo studente dovrà modellare ed implementare una classe una classe per i numeri complessi.
A tal fine, si prenda in considerazione la classe `Complex` ed i suggerimenti puntuali ivi forniti e se ne completi il codice affinché l'esecuzione di `Program` abbia senso.

## Esercizio 3 - Calcolo

Il progetto `Calculus` prevede l'implementazione di una classe le cui istanze fungano da calcolatrici per i numeri complessi.
Questa impiegherà al suo interno la classe per i numeri complessi definita nell'esercizio precedente (non c'è bisogno di copiarla, né riscriverla).

La classe `Program` rappresenta il punto d'ingresso dell'applicazione e, come esempio, mostra un flusso di operazioni svolte sulla calcolatrice ed il loro risultato.

Scopo dell'esercizio è imparare a modellare ed implementare in .NET un oggetto con stato mutevole, che possa essere osservato tramite proprietà ed alterato mediante metodi. 
In particolare, lo studente dovrà modellare ed implementare una classe una classe che rappresenti una calcolatrice di numeri complessi.
A tal fine, si prenda in considerazione la classe `Calculator` ed i suggerimenti puntuali ivi forniti e se ne completi il codice affinché l'esecuzione di `Program` abbia senso.

Si immagini la calcolatrice come avente un display capace di visualizzare un solo numero complesso alla volta e 3 tasti: '+', '-', '=' e 'Reset'.
Properità e metodi dovranno modellare questa situazione.
Si aggiungano campi privati atti a modellare lo stato interno della calcolatrice.

## Esercizio 4 - Array

Il progetto `Arrays` prevede l'implementazione di alcuni semplici algoritmi sugli array di numeri complessi.

La classe `Program` rappresenta il punto d'ingresso dell'applicazione in cui gli algoritmi definiti all'interno della medesima classe sono testati su array noti di numeri complessi.

Scopo dell'esercizio è imparare ad operare con gli array di oggetti e completare la classe `Program` affinché l'esecuzione del metodo `Main` ivi contenuto abbia senso.

Gli algoritmi da implementare sono in particolare:
- indentificazione del numero complesso col modulo più ampio in un array
- clonazione di un array di numeri complessi (sia lo studente a scegliere se sia più opportuna una copia profonda o superficiale)
- ordinamento di un array di complessi per fase crescente

Esempi di algoritmi analoghi, seppure sugli interi, sono forniti nella classe `Examples`.

## Esercizio 5 - Iteratori

Il progetto `Iterators` è finalizzato alla comprensione delle analogie e delle differenze tra gli Stream di Java 8 e gli enumerabili di .NET.
Per ciò, viene fornita la classe `Java8StreamOperations` contenente le firme di alcuni metodi estensione aventi gli stessi nomi dei metodi dell'interfaccia `Stream` di Java 8 (p.e. `map`, `filter`, `reduce`, etc).

Scopo dell'esercizio è implementare i suddetti metodi --- auspicabilmente sfruttando il costrutto degli [iteratori di C-Sharp](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators) -- affinchè i metodi della classe `Java8StreamOperations` si comportino come gli omonimi definiti in Java, a cui siamo abituati.
Per verificare la correttezza delle proprie implementazioni, l'esercizio prevede infine che la pipeline di elaborazione presente nella classe `Program` venga riscritta sfruttando i metodi estensione precedentemente implementati.

## Esercizio 6 - Indicizzatori & generici

Il progetto `Indexers` consiste in una semplice libreria che fornisce l'astrazione di mappa bidimensionale (cioè mappa con due chiavi). 
Il progetto fornisce l'interfaccia `IMap2D<TKey1, TKey2, TValue>`, che mostra i metodi forniti da una mappa bi-dimensionale.
Le implementazioni dell'interfaccia `IMap2D` permettono di memorizzare valori di tipo `TValue` in quella che può essere pensata come una matrice sparsa, in cui le righe sono indicizzare con valori di tipo `TKey1` e le colonne con valori di tipo `TKey2`.
Dato un oggetto `IMap<TKey1, TKey2, TValue> map` e due chiavi `k1` di tipo `TKey1` e `k2` di tipo `TKey2`, si accede al valore corrispondente con la sintassi `map[k1, k2]`.

Scopo dell'esercizio è implementare la classe `Map2D<TKey1, TKey2, TValue>`.
Il test contenuto nel progetto `2-IndexersTests` tenta di chiarire il comportamento atteso per una classe che implementi `IMap2D`.
L'esercizio si può considerare concluso quando tutti i test terminano con successo.
