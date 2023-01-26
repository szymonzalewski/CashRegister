# CashRegister

W projekcie znajduą się trzy klasy `Program`, `Product` i `CashRegister`.

## Klasa Program
  Jest to standardowa klasa ustalona w wymaganiach C#, która zawiera metodę `Main`. Nasępująca metoda jest uruchamiana przy starcie programu.
  
  
## Klasa Product
  **Niniejsza klasa zawiera pola:**
  - `quantity` jest prywatna i statyczna oraz typu `int` (Za jej pomocą zostaje ustalone `id` i inkrementuje się po wyołaniu konstruktora),
  - `id` jest typu `int`,
  - `name` jest typu `string`,
  - `description` jest typu `string`,
  - `price` jest typu `double`.
  
  **zawiera metody*:*
  - `Print`: wypisuje wartości pól w konsoli.
  
Jej głównym przeznaczeniem jest przechowywanie informacji, które będą wykorzystywane w`CashRegister`. 

## Klasa CashRegister
  **Niniejsza klasa zawiera pola:**
  - `Products` jest typu List<Product>.
  
  **zawiera metody:**
  - `AddProduct`: przymuje jedną wartość typu `Product` i dodaje go do listy `Products`
  - `RemoveProduct`: posiada dwa przeciążenia
      - 1. Przyjmuje jedną wartość typu `Product` i usuwa go z listy `Product`.
      - 2. Przyjmuje jedną wartość typu `int`, która usuwa jeden element z listy `Product` o tym index-sie.
  - `FullPrice`: Zwraca sumę elementów z listy `Products` z pola `price` i ją zwraca.
  - `Print`: Iteruje po wszystkich elementach listy `Products` i wywołuje ich metode `Print` oraz wypisuje wartość zwracaną przez metode `FullPrice`.
  - `Payment`: Przyjmuje jedną wartość typu `double` następnie sprawdza czy posiadasz wystarczące środki na koncie i czy są zarejestrowane jakieś produkty. Następnie odejmuje sume produktów, którą następnie odejmuje od wprowadzonej warości i watość tego działania zwraca. 
