#3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF) - Mini užduotys - 2 užd.

##Sąlyga

Sukurkite WPF programėlę, kuri susidėtų iš vieno mygtuko ir paveiksliuko elemento (tarkime linksmo veiduko), paspaudus mygtuką paveiksliukas turėtų vieną kartą apsisukti 360 laipsnių, sukimosi animacija turėtų trukti apie 2 sekundes.

##Patarimai

1. Programėlei sukurti reikia apibrėžti paveiksliuko animaciją. Tam geriausia naudoti įrankį *Blend for Visual Studio 2013*.
2. Yra keli būdai paleisti animaciją:
  1. Iš programinio kodo iškviesti `storyboard.Begin()`, kur **storyboard** - animacijos objektas
  2. *Blend* redaktoriuje uždėti trigerį, kad paspaudus mygtuką sugrotų animacija.
	