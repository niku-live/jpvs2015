##Sąlyga

Panaudojant vien HTML elementus sukurkite puslapį kuris atrodytų taip:
![Example 1](https://raw.githubusercontent.com/niku-live/jpvs2015/master/05%20tema%20-%20Web%20-%20HTML%20ir%20CSS/Mini%20Problems/Vol5Ex1/example1.png)

##Patarimai

1. Užduočiai atlikti prisireiks šių elementų:
  1. **DIV konteineris** - standartinis HTML konteineris skirtas kitiems elementams grupuoti. Paprastai visi kiti elementai kuriami DIV konteinerių viduje. Redaktoriaus paletėje elementas vadinasi **Div**. HTML kode elementas pradedamas žyme `<div>`, o užbaigiamas žyme `</div>`, viskas, kad parašyta tarp `<div>` ir `</div>` laikoma, jog yra DIV konteinerio viduje.
  2. **Horizontalios linijos** - HTML elementas per visą puslapį nupaišantis horizontalią liniją. Paletėje vadinamas **Horizontal rule**, HTML kode užrašomas žyme `<hr/>`. Dažnai naudojamas ir kitas elementas `<br/>`, kuris atitinka, tiesiog perkėlimą į kitą eilutę.
  3. **Teksto įvedimo laukelis** - elementas tekstui įvesti. Paletėje vadinamas **Input (text)**, HTML kode užrašomas žyme `<input type="text" />`.
  4. **Mygtukas** - elementas mygtukui atvaizduoti. Paletėje vadinamas **Input (button)**, HTML kode užrašomas žyme `<input type="button"/>`. Mygtukui taip pat dažnai nustatoma savybė **value**, tada jis turi pavadinimą, pvz. `<input type="button" value="Mygtukas 1"/>` sukurs mygtuką, kuris turės savo viduje tekstą "Mygtukas 1".
2. Kad būtų paprasčiau koreguoti dokumentus, rekomenduoju įsijungti **HTML (Web Forms)** rėžimą, tai padaroma Visual Studio lange virš pirmojo sukurto .html failo paspaudus dešinį pelės klavišą ir pasirinkus "Open With", tada pažymėjus HTML (Web Forms) Editor ir paspaudus mygtuką "Set as Default". Tai atlikus failo koregavimo lange apačioje kairtėje bus mygtukai **Design**, **Split** ir **Source**, siūlyčiau naudoti **Split**. Plačiau apie šiuos mygtukus:
  1. **Design** - rodomas tik pusplapio vaizdas be HTML kodo. Tokiame koregavimo rėžime galima tiesiog dėlioti elementus ir paletės ir keisti savybės pelės pagalba, koreguoti HTML kodo rankomis negalima.
  2. **Source** - rodomas tik HTML puslapio kodas ir visas puslapis koreguojamas keičiant kodą.
  3. **Split** - apjungiami **Design** ir **Source** langai, t.y. rodomas tiek HTML kodas, tiek puslapio vaizdas.

##Eiga

1. Sukurkite naują Visual Studio ASP.NET projektą:
  1. Pasirenkate *File -> New -> Project*
  2. Iš šablonų pasirenkate *Visual C# -> Web -> ASP.NET Web Application Project*
  3. Lange "New ASP.NET Project" pasirenkate Empty (kadangi kursime paprasčiausią HTML puslapį) ir atžymite varnelę "Host in the Cloud".
2. Pridėkite naują HTML failą (Project -> Add New Item... -> HTML Page).
3. Pakoreguokite failą taip, kad gautumėte norimą vaizdą. 
  1. Į puslapį įdėkite DIV konteinerį (`<div></div>` elementas HTML kode arba **Div** elementas iš paletės).
  2. Konteineryje įdėkite tris horizontalias linijas (`<hr/>` elementas HTML kode arba **Horizontal Rule** elementas iš paletės).
  3. Po pirmosios horizontaliosios linijos parašykite tekstą "Teksto laukelis" ir įterpkite tekstinio laukelio elementą (`<input type="text"/>` elementas HTML kode arba **Input (text)** elementas iš paletės.
  4. Po antrosios horizontaliosios linijos įterpkite du mygtuko elementus (`<input type="button"/>` elementas HTML kode arba **Input (Button)** elementas iš paletės).
  5. Pakeiskite mygtukų savybes **value** atitinkamai į "Mygtukas 1" ir "Mygtukas 2".
4. Paleiskite puslapį pasirinkę Debug -> Start Debugging.