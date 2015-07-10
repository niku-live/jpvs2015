##Sąlyga

3 užduotimi sukurtą puslapį papildykite, kad atrodytų kaip pateiktame paveiksliuke:
![Example 4](https://raw.githubusercontent.com/niku-live/jpvs2015/master/05%20tema%20-%20Web%20-%20HTML%20ir%20CSS/Mini%20Problems/Vol5Ex4/example4.png)

##Patarimai

1. Viršui, šoninei juostai ir centrui sukurkite atskirus DIV kontainerius, konteineriams suteikite unikalius id.
2. Šioje užduotyje reikėtų pasinaudoti CSS stiliaus savybe `float: left;` bei savybėmis **width** ir **height**.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. Papildykite HTML failą:
  1. Anksčiau sukurtam DIV elementui suteikite savybę `id="body"`.
  2. Anksčiau ansktesnio DIV elemento sukurkite naują DIV elementą `<div id="top">Viršus</div>`.
  3. Sukurkite dar vieną elementą (tarp dviejų anksčiau sukurtų) `<div id="left"></div>`, viduje elemento sudėkite elementus **Menu1**, **Menu2**...  
3. Pakoreguokite CSS failą taip, kad gautumėte norimą vaizdą.  
  1. Sukurkite stilių pavadinimu `#top` ir nurodykite `height: 10%;`, `width: 100%;`, `background-color: yellow;`.
  2. Sukurkite stilių pavadinimu `#left` ir nurodykite `width: 100px;`, `background-color: gray;`, `float: left`.
  3. Sukurkite stilių pavadinimu `#body` ir nurodykite `margin-left:20px`, `float: left`.
6. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.