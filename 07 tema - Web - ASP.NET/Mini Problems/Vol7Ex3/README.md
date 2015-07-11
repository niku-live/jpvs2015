#7 tema - Internetinės aplikacijos - ASP.NET - Mini užduotėlės - 3 užd.

##Sąlyga

2 užduotimi sukurtą puslapį pakoreguokite, kad puslapio apačioje rodytų lentelę, kurios turinys susidėtų iš failo Data.xml turinio. Failas būtų tokio formato:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Data>
  <User Name="Vardas" LastName="Vardukas" Age="21" UserType="Admin"/>
  <User Name="Vardas2" LastName="Vardukas2" Age="25" UserType="User"/>
</Data>
```
Galutinis puslapio vaizdas galėtų būti toks:
![Galimas puslapio vaizdas](https://raw.githubusercontent.com/niku-live/jpvs2015/master/07%20tema%20-%20Web%20-%20ASP.NET/Mini%20Problems/Vol5Ex3/example3.png)

##Patarimai

1. Duomenims lentelės pavidalu atvaizduoti geriausia naudoti **GridView** komponentą (pasirenkamą iš paletės).
2. **GridView** komponentas duomenis atvaizduoja pasinaudodamas duomenų šaltiniu. Duomenų šaltinis nurodomas pakeitus komponento **DataSourceID** savybę.
3. XML failams duomenų šaltinį atstoja komponentas **XmlDataSource** (pasirenkamas iš paletės). Komponentą su failu galima susieti pakeitus **DataFile** savybę.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. Iš meniu pasirinkite *Project -> Add New Item...*, pasirinkite *"XML File"* ir spauskite Add.
3. Užpildykite naujai sukurto failo turinį taip:
```xml
<?xml version="1.0" encoding="utf-8" ?>
<Data>
  <User Name="Vardas" LastName="Vardukas" Age="21" UserType="Admin"/>
  <User Name="Vardas2" LastName="Vardukas2" Age="25" UserType="User"/>
  <User Name="Vardas3" LastName="Vardukas3" Age="27" UserType="User"/>
  <User Name="Vardas4" LastName="Vardukas4" Age="22" UserType="User"/>
  <User Name="Vardas5" LastName="Vardukas5" Age="20" UserType="User"/>
</Data>
```
4. Į puslapį įtraukite komponentą **XmlDataSource** (tiesiog pasirinkite iš paletės), komponentui užpildykite savybes taip:
  1. **DataFile** - šioje savybėje reikia įrašyti sukurto failo pavadinimą.
  2. **XPath** * - ši savybė nurodo, kuriuos duomenis norime atvaizduoti iš failo. Nurodykite reikšmė **"Data/User"**.
5. Į puslapį įtraukite komponentą **GridView**. Pakeiskite savybes taip:
  1. **DataSourceID** - šioje savybėje nurodomas duomenų šaltinis. Pasirinkite šaltinį, sukurtą 4 punktu (tikriausiai pavadinimas bus *XmlDataSource1*)
  2. Pakoreguokite savybes aprašančias išvaizdą.
6. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.