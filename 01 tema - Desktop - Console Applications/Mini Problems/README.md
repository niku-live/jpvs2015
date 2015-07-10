##1 tema: Konsolinės aplikacijos

##Mini užduotėlės

###1 užd. (https://github.com/niku-live/jpvs2015/tree/master/01%20tema%20-%20Desktop%20-%20Console%20Applications/Mini%20Problems/Vol1Ex1_AllReversing)
- Sąlyga: Sukurkite konsolinę programėlę, kuri viską, ką įveda vartotojas, išveda atvirkščiai (pvz. įvedus "Labas", išvedama "sabaL"). 
- Patarimai: naudokite string klasės standartinę komandą Reverse(), pvz.: string s = "Labas"; s = s.Reverse();

###2 užd. (https://github.com/niku-live/jpvs2015/tree/master/01%20tema%20-%20Desktop%20-%20Console%20Applications/Mini%20Problems/Vol1Ex2_StartupParams)
- Sąlyga: Sukurkite konsolinę programėlę, kuri išspausdintų į ekraną viską, kas pateikiama kaip programos paleidimo parametrai (t.y. jei programa vadinasi programele.exe ir ji paleidžiama iš komandinės eilutės surinkus "programele.exe test1 test2 test3", tai atskirose eilutėse turėtų būti išspausdinamas tekstas "test1", "test2", "test3").
- Patarimai: naudokite masyvą "args", kuris yra standartinio metodo Main vienintelis parametras.

###3 užd. (https://github.com/niku-live/jpvs2015/tree/master/01%20tema%20-%20Desktop%20-%20Console%20Applications/Mini%20Problems/Vol1Ex3_MovingSymbol)
- Sąlyga: Sukurkite konsolinę programėlę, kuriai pasileidus tiesiog išvedamas vienas simbolis "#", tačiau po to galima klaviatūros pagalba (paspaudus vieną iš klavišų "a", "s", "d", "w") šį simbolį judinti ekrane, t.y. paspaudus klavišą "d" simbolis pajuda per vieną simbolį į dešinę, paspaudus "s", simbolis pajuda viena eilute žemiau.
- Patarimai: 1) nuskaityti paspaudam klavišui naudokite komandą Console.ReadKey(true); 2) pakeisti kursoriaus poziciją naudokite komandą Console.SetCursorPosition(x, y)

###4 užd. (https://github.com/niku-live/jpvs2015/tree/master/01%20tema%20-%20Desktop%20-%20Console%20Applications/Mini%20Problems/Vol1Ex4_MusicBox)
- Sąlyga: Sukurkite konsolinę programėlę, kuri lauktų paspaudžiamo klavišo ir paspaudus tam tikrą klavišą išvestų garsinį signalą
- Patarimai: 1) nuskaityti paspaudam klavišui naudokite komandą Console.ReadKey(true); 2) išvesti garsiniam signalui naudokite komandą Console.Beep(frequency, duration)