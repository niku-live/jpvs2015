#12 tema - Mikrovaldikliai - RaspberryPi

**RaspberryPi** - tai nedidelės dėžutės dydžio kompiuteris, kuris gali būti naudojamas vietoj **Arduino** valdiklių įvairių įrenginių valdymui. Kadangi tai įprastas kompiuteris, tai **RaspberryPi** turi daug galimybių, kurių **Arduino** nedali suteikti, vis tik tai kartu reiškia ir tai, kad įrenginys užtrunka, kol paleidžiama operacinė sistema bei sunaudojamas energijos kiekis daug didesnis. Įprastai **RasberryPi** naudoja Raspbian Linux operacinę sistemą, tačiau galima sudiegti ir alternatyvias operacines sistemas, tokias kaip Android, Windows 10 IoT ir pan.

##Trumpai
Kadangi **RasberryPi** - normalus kompiuteris, tai programas jam galima kurti įvairiomis programavimo kalbomis - C, C++, Java, C#, Python, Ruby ir pan. Keletą patarimų:
- Programas galima sukurti naudojant bet kokius programavimo įrankius, tačiau po to programą reikią perkelti į **RasberryPi**. 
- Programas perkelti į įranginį galima su FileZilla ar panašiais FTP klientais. 
- Prisijungimui prie pačio įrenginio galima naudoti PuTTY programėlę, 
- Jei naudojama C ar C++ kalba, programas galiam kompiliuoti tiesiai **RasberryPi** pasinaudojus komanda `gcc programa.c -lwiringPi -o sukompiliuota.o`, kur **programa.c** - failas, kurį kompiliuojame, **sukompiliuota.o** - sukompiliuotas failas.
- Sukompiliuotą programą galima paleisti surinkus komandą `sudo ./sukompiliuota.o`, kur **sukompiliuota.o** - programa, kurią norime paleisti.
- Jei norima koreguoti failą pačiame įrenginyje, tą galima padaryti surinkus komandą `nano programa,c`, kur **programa.c** - failas, kurį norime koreguoti.
  
##Video įrašai
- [Video 10](https://github.com/niku-live/jpvs2015/blob/master/VIDEO.md#video-10)

##[Pavyzdžiai](https://github.com/niku-live/jpvs2015/tree/master/12%20tema%20-%20Micro%20-%20RaspberryPi/Examples)

##[Mini užduotys](https://github.com/niku-live/jpvs2015/tree/master/12%20tema%20-%20Micro%20-%20RaspberryPi/Mini%20Problems)

##Iššūkiai
- [Challenge7](https://github.com/niku-live/jpvs2015/blob/master/CHALLANGES.md#challange7)