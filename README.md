# WeatherStation

Prosta aplikacja, proces tworzenia której jest opisany w książce "WPF i MaterialDesign - Od podstaw do tworzenia praktycznych aplikacji", ISBN: 978-83-289-2398-0, autor: Rafał Klinowski.

## Założenia

- Chcemy wykorzystać wiedzę, którą nabyliśmy do tej pory, między innymi data binding, style oraz co najmniej kilka typów kontrolek.
- Chcemy, aby aplikacja była prosta i nie była przeładowana - ma być wykorzystywana w jednym celu, lecz ma zawierać funkcje związane z tym celem.
- Chcemy, aby aplikacja była ładna, przejrzysta i responsywna.
- Chcemy pozbyć się domyślnego stylu okien WPF (m.in. paska na górze okna).
- Chcemy, aby aplikacja była w języku polskim. Nadal będziemy pisać kod (m.in. nazwy klas czy zmiennych) w języku angielskim.

## Rozszerzenia

- Strona z ustawieniami dla użytkownika - warto zawrzeć tam takie opcje, jak tryb jasny/ciemny oraz sposób wyświetlania danych. Można na przykład wydzielić konwersje liczb zmiennoprzecinkowych w taki sposób, aby możliwe było ustawienie ich wyświetlania z przecinkiem lub kropką. Dobrym pomysłem mogłoby być też umożliwienie użytkownikowi zmiany jednostek wyświetlanych danych (np. stopni Celsjusza na Farenheita) przy pomocy nowej klasy typu \texttt{Helper}. Warto również zapisywać w jakiś sposób dane użytkownika i wczytywać je podczas startu aplikacji (metoda \texttt{OnStartup} w klasie App).
- Rozszerzenie strony wyświetlającej dane poprzez uwzględnienie większej ilości właściwości (np. temperatura odczuwalna, widoczność, zachmurzenie). Dane te mamy już zdefiniowane w klasach aplikacji - wystarczy dodać jedynie więcej elementów typu \textt{Card}, zmniejszając przy tym ich rozmiar lub umieszczając je wewnątrz kontrolki \texttt{ScrollViewer}.
- Zmiana ikonki aplikacji - patrz Rozdział 4.
- Poeksperymentowanie z paletami kolorów - zmiana kolorystyki, dodanie więcej elementów w kolorze akcentu, itp.
