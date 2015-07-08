##Sąlyga

1 užduotimi sukurtą puslapį papildykite CSS failų ir jį pakeiskite taip, kad puslapis atrodytų taip:
https://raw.githubusercontent.com/niku-live/jpvs2015/master/MiniProblems/5%20tema%20-%20HTML%20ir%20CSS/Vol5Ex2/example2.png

##Patarimai
```html
1. Kad HTML faile būtų naudojamas CSS failas, juos tarpusavyje riekia susieti <link> elementos pagalba.
2. CSS failas susideda iš stilių aprašymų, susieti konkretų stilių su HTML elementu galima keliais būdais:
   a) CSS faile stilių vadinti HTML elemento pavadinimu. Tada visi HTML elementai su tokiu pavadinimu turės tokį stilių.
   b) CSS faile stilių vadinti "#pavadinimas" ir konkrečiam HTML elementui priskirti savybę "id="pavadinimas"" tokiu atveju tas vienintelis elementas HTMl faile turės tokį stilių.
   c) CSS faile stilių vadinti ".pavadinimas" ir HTML elementams priskirti savybę "class="pavadinimas"", tokiu atveju visi elementas turintys savybę "class="pavadinimas"" turės tokį stilių.
```

##Eiga
```html
1. Atidarykite anksčiau sukurtą projektą.
2. Pridėkite naują CSS failą (Project -> Add New Item... -> Style Sheet).
3. Susiekite CSS failą su HTML failu:
  a) Atidarykite HTML failą
  b) Tarp <head> ir </head> elementų įrašykite tekstą "<link rel="stylesheet" type="text/css" href="theme.css">", kur "theme.css" yra sukurto CSS failo pavadinimas.
4. HTML faile papildomai pridėkite 1 mygtuką ir vieną tekstinį laukelį, tekstus "Teksto laukelis" ir "Teksto laukelis 2" pakiškite po elementu "<label></label>".
5. Priskirkite HTMl faile elementams savybes:
   a) Pirmam tekstiniam laukeliui priskirkite savybę "id="Text1"".
   b) Pirmiems dviem mygtukams priskirkite savybę "class="melynas_mygtukas""
5. Pakoreguokite CSS failą taip, kad gautumėte norimą vaizdą.  
  a) Sukurkite stilių pavadinimu ".melynas_mygtukas" ir nurodykite "background_color: blue;", "color: red;".
  b) Sukurkite stilių pavadinimu "#Text1" ir nurodykite "color: red;".  
  c) Sukurkite stilių pavadinimu "label" ir nurodykite "color: green;".
6. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```