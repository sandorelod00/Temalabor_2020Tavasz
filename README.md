# Témalabor doukmentáció

## Téma
Játék fórum oldal, verseny kiírásra és diskurzusra

## Leírás
Az oldal a játék felhasználói számára létrehozott közösségi portál, amin tájékozódhatnak az aktuális versenyekről, illetve bármilyen, a játékkal kapcsolatos bejegyzéseket írhatnak, olvashatnak. Az oldal a játékot magát nem valósítja meg, csak lehetőséget ad a játékosok weben történő kapcsolattartására.

## Felépítés
Oldal tetején menüszalagként funkcionáló fejléc. Ennek elemei balról jobbra:
  **•	Logo**
    Alapvetően csak kozmetikai részlet, illetve rákattintva átirányít a kezdő oldalra.
  **•	Forum** (kezdőlap)
    Forum kér különböző médiaformátumot tárol:
    o	Verseny kiírás: Adminisztrátoroknak van lehetősége a játékban versenyeket kiírni. 
      Verseny kiírás formája: Esemény kép, esemény cím, versenyt kiíró felhasználó, rövid leírás stb. Funkcionális elemek: versenyre jelentkezés gomb, amire, ha rányomunk, automatikusan leiratkozás gombra vált, állapotát tárolni kell, illetve lehetséges az eseményhez    kommentelni
    o	Poszt: Bármely felhasználó írhat ki posztot, ezek a játékkal kapcsolatos fórumbejegyzések.
      Poszt formája: cím, bejegyzés szöveg, kiíró felhasználó, dátum, illetve ez alá is lehet kommentelni. Forumon lefelé görgetve akarjuk betölteni a korábbi posztokat. Akár poszt, akár verseny címére kattintva átirányítunk egy olyan nézetre, ahol csak az adott bejegyzés tekinthető meg, ekkor bővebb tartalom érhető el, illetve ilyenkor láthatjuk a kommenteket. 
  **•	My profile**
  Saját profilban a saját adatokat lehet módosítani (alias, leírás, profil kép, ha van rank, stb)
Itt lehet egy felhasználó ismerőseinek listáját megtekinteni, illetve itt lehet kiírni versenyt vagy posztot, felhasználói szinttől függően
•	**Search**
  Keresés posztra (cím, leírás, dátum alapján), versenykiírásra (cím, leírás, dátum alapján), vagy felhasználóra (név alapján), kulcsszavasan. Poszt/versenykiírásra kattintás esetén ugyanabba a bővebb nézetbe, mint fórum böngészés esetén. 
Felhasználóra kattintva megnézhetjük egy másik felhasználó profilját neve melletti gomb segítségével ismerősnek jelölhetjük, illetve megtekinthetjük adatait. (A nézet hasonlít a teljes saját profil nézetre)
**•	Register**
  Regisztrálás személyes adatok megadásával.
Kezdetben mindenki alap felhasználói jogosultságokat kap, adminisztrátori jogosultsággal a rendszergazdák (eleinte) vagy más adminisztrátorok ruházhatnak fel.
**•	Login**
  Meglévő felhasználói fiókkal való belépés
## Felhasználói profilok megtekintése
Alapvetően a képernyő bal oldalán egy függőleges (collapse-olható) sávban a felhasználó saját profiljának **gyorsnézete** látható, amennyiben be van jelentkezve. A saját profilnak van egy **teljes képernyős nézete** is, itt olyan extra információk vannak, mint az ismerős lista. Ezt kétféleképpen lehet megnyitni; A felső menüszalagon a „my profile” gombra kattintva, illetve a bal oldali gyors nézeten a felhasználónevünkre való kattintás után.
Ezentúl más felhasználók profiljának nézete hasonlít a saját profilunk teljes nézetére, azzal a különbséggel, hogy nem tudjuk adataikat módosítani, illetve nevük mellett egy **ismerősnek jelölésre alkalmas gomb** (melynek megnyomására a felhasználó felkerül az ismerőslistánkra) található.
