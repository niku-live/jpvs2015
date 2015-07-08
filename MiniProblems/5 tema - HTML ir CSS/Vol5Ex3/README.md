##Sąlyga

2 užduotimi sukurtą puslapį papildykite dar vienu CSS failų ir padarykite, kad jis būtų naudojamas naršyklėje pasirinkus "Print Preview" (t.y. kad skirtingi stiliai būtų naudojami atvaizdavimui ir spausdinimui". Spaudinimo vaizdas turėtų atrodyti panašiai į tokį (atkreipkite dėmesį, kad 3 mygtukas paslėptas):
https://raw.githubusercontent.com/niku-live/jpvs2015/master/MiniProblems/5%20tema%20-%20HTML%20ir%20CSS/Vol5Ex2/example2.png

##Patarimai
```html
1. Kad spausdinimui būtų naudojamas kitas CSS failas, HTML faile reikia sukurti dar vieną <link> elementą, kuriame nurodyti savybę "media="print"".
2. CSS pagalba paslėpti elementą galima nurodžius "display:none;"
```

##Eiga
```html
1. Atidarykite anksčiau sukurtą projektą.
2. Pridėkite naują CSS failą (Project -> Add New Item... -> Style Sheet).
3. Susiekite CSS failą su HTML failu ir nurodykite, kad tai spausdinimui skirtas CSS:
  a) Atidarykite HTML failą
  b) Tarp <head> ir </head> elementų įrašykite tekstą "<link rel="stylesheet" type="text/css" href="theme_print.css" media="print">", kur "theme_print.css" yra sukurto CSS failo pavadinimas.
4. Trečiam mygtukui HTML faile priskirkite savybę "id="Button3".
6. Pakoreguokite naujajį CSS failą taip, kad gautumėte norimą vaizdą.  
  a) Sukurkite stilių pavadinimu ".melynas_mygtukas" ir nurodykite "background_color: white;", "color: black;".
  b) Sukurkite stilių pavadinimu "#Text1" ir nurodykite "color: black;".  
  c) Sukurkite stilių pavadinimu "label" ir nurodykite "color: black;".
  d) Sukurkite stilių pavadinimu "#Button3" ir nurodykite "display:none;".
6. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```