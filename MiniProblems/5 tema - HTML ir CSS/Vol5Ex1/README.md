##Sąlyga

Panaudojant vien HTML elementus sukurkite puslapį kuris atrodytų taip:

##Patarimai

1. Užduočiai atlikti prisireiks šių elementų:
  a) DIV konteineris - standartinis HTML konteineris skirtas kitiems elementams grupuoti. Paprastai visi kiti elementai kuriami DIV konteinerių viduje. Redaktoriaus paletėje elementas vadinasi "Div". HTML kode elementas pradedamas žyme "<div>", o užbaigiamas žyme "</div>", viskas, kad parašyta tarp "<div> ir </div>" laikoma, jog yra DIV konteinerio viduje.
  b) Horizontalios linijos - HTMl elementas per visą puslapį nupaišantis horizontalią liniją. Paletėje vadinamas "Horizontal rule", HTML kode užrašomas žyme "<hr/>. Dažnai naudojamas ir kitas elementas "<br/>", kuris atitinka, tiesiog perkėlimą į kitą eilutę.
  c) Teksto įvedimo laukelis - elementas tekstui įvesti. Paletėje vadinamas "Input (text)", HTML kode užrašomas žyme "<input type="text" />".
  d) Mygtukas - elementas mygtukui atvaizduoti. Paletėje vadinamas "Input (button)", HTML kode užrašomas žyme "<input type="button"/>". Mygtukui taip pat dažnai nustatoma savybė "value", tada jis turi pavadinimą, pvz. "<input type="button" value="Mygtukas 1"/>" sukurs mygtuką, kuris turės savo viduje tekstą "Mygtukas 1".
2. Kad būtų paprasčiau koreguoti dokumentus, rekomenduoju įsijungti "HTML (Web Forms)" rėžimą, tai padaroma Visual Studio lange virš pirmojo sukurto .html failo paspaudus dešinį pelės klavišą ir pasirinkus "Open With", tada pažymėjus HTML (Web Forms) Editor ir paspaudus mygtuką "Set as Default". Tai atlikus failo koregavimo lange apačioje kairtėje bus mygtukai "Design", "Split" ir "Source", siūlyčiau naudoti "Split". Plačiau apie šiuos mygtukus:
  a) Design - rodomas tik pusplapio vaizdas be HTML kodo. Tokiame koregavimo rėžime galima tiesiog dėlioti elementus ir paletės ir keisti savybės pelės pagalba, koreguoti HTML kodo rankomis negalima.
  b) Source - rodomas tik HTML puslapio kodas ir visas puslapis koreguojamas keičiant kodą.
  c) Split - apjungiami Design ir Source langai, t.y. rodomas tiek HTML kodas, tiek puslapio vaizdas.


##Eiga

1. Sukurkite naują Visual Studio ASP.NET projektą:
  a) Pasirenkate File -> New -> Project
  b) Iš šablonų pasirenkate Visaul C# -> Web -> ASP.NET Web Application Project
  c) Lange "New ASP.NET Project" pasirenkate Empty (kadangi kursime paprasčiausią HTML puslapį) ir atžymite varnelę "Host in the Cloud".
2. Pridėkite naują HTML failą (Project -> Add New Item... -> HTML Page).
3. Pakoreguokite failą taip, kad gautumėte norimą vaizdą. 
  a) Į puslapį įdėkite DIV konteinerį (<div></div> elementas HTML kode arba Div elementas iš paletės).
  b) Konteineryje įdėkite tris horizontalias linijas (<hr/> elementas HTML kode arba "Horizontal Rule" elementas iš paletės).
  c) Po pirmosios horizontaliosios linijos parašykite tekstą "Teksto laukelis" ir įterpkite tekstinio laukelio elementą (<input type="text"/> elementas HTML kode arba "Input (text)" elementas iš paletės.
  d) Po antrosios horizontaliosios linijos įterpkite du mygtuko elementus (<input type="button"/> elementas HTML kode arba "Input (Button)" elementas iš paletės).
  e) Pakeiskite mygtukų savybes "value" atitinkamai į "Mygtukas 1" ir "Mygtukas 2".
4. Paleiskite puslapį pasirinkę Debug -> Start Debugging.