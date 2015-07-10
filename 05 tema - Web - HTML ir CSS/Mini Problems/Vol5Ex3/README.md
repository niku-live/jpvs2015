##Sąlyga

2 užduotimi sukurtą puslapį papildykite dar vienu CSS failų ir padarykite, kad jis būtų naudojamas naršyklėje pasirinkus "Print Preview" (t.y. kad skirtingi stiliai būtų naudojami atvaizdavimui ir spausdinimui". Spaudinimo vaizdas turėtų atrodyti panašiai į tokį (atkreipkite dėmesį, kad 3 mygtukas paslėptas):
![Example 3](https://raw.githubusercontent.com/niku-live/jpvs2015/master/05%20tema%20-%20Web%20-%20HTML%20ir%20CSS/Mini%20Problems/Vol5Ex3/example3.png)

##Patarimai

1. Kad spausdinimui būtų naudojamas kitas CSS failas, HTML faile reikia sukurti dar vieną `<link>` elementą, kuriame nurodyti savybę `media="print"`.
2. CSS pagalba paslėpti elementą galima nurodžius `display:none;`.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. Pridėkite naują CSS failą (*Project -> Add New Item... -> Style Sheet*).
3. Susiekite CSS failą su HTML failu ir nurodykite, kad tai spausdinimui skirtas CSS:
  1. Atidarykite HTML failą
  2. Tarp `<head>` ir `</head>` elementų įrašykite tekstą `<link rel="stylesheet" type="text/css" href="theme_print.css" media="print">`, kur **theme_print.css** yra sukurto CSS failo pavadinimas.
4. Trečiam mygtukui HTML faile priskirkite savybę `id="Button3`.
5. Pakoreguokite naujajį CSS failą taip, kad gautumėte norimą vaizdą.  
  1. Sukurkite stilių pavadinimu `.melynas_mygtukas` ir nurodykite `background_color: white;`, `color: black;`.
  2. Sukurkite stilių pavadinimu `#Text1` ir nurodykite `color: black;`.  
  3. Sukurkite stilių pavadinimu `label` ir nurodykite `color: black;`.
  4. Sukurkite stilių pavadinimu `#Button3` ir nurodykite `display:none;`.
6. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.