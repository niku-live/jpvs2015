##Sąlyga

5 temos 4 užduotimi sukurtą puslapį papildykite, kad paspaudus pirmas mygtuką būtų išmetamas pranešimas "paspausta".

##Patarimai
```html
1. Paspaudimo įvykiui kontroliuoti naudokite mygtuko savybę "onclick".
2. Užduočiai įgyvendinti reikėtų sukurti sukurti naują javascript failą, jame naują funciją, o joje panaudoti javascript komandą "alert"
```

##Eiga
```html
1. Atidarykite anksčiau sukurtą projektą.
2. Pridėkite naują Javascrip failą (Project -> Add New Item... -> Javascript file).
3. Susiekite Javascript failą su HTML failu:
  a) Atidarykite HTML failą
  b) Tarp <head> ir </head> elementų įrašykite tekstą "<script src="test.js"></script>", kur "test.js" yra sukurto Javascript failo pavadinimas.

4. Papildykite Javascript failą - sukurkite naują funkciją "click1":
  function click1()
  {
    alert("paspausta");
  }
3. HTML faile pirmam mygtukui nustatykite savybę "onclick="click1()"".
4. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```