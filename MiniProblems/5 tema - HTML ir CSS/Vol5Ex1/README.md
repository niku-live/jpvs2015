##Sàlyga

Panaudojant vien HTML elementus sukurkite puslapá kuris atrodytø taip:

##Patarimai

1. Uþduoèiai atlikti prisireiks ðiø elementø:
  a) DIV konteineris - standartinis HTML konteineris skirtas kitiems elementams grupuoti. Paprastai visi kiti elementai kuriami DIV konteineriø viduje. Redaktoriaus paletëje elementas vadinasi "Div". HTML kode elementas pradedamas þyme "<div>", o uþbaigiamas þyme "</div>", viskas, kad paraðyta tarp "<div> ir </div>" laikoma, jog yra DIV konteinerio viduje.
  b) Horizontalios linijos - HTMl elementas per visà puslapá nupaiðantis horizontalià linijà. Paletëje vadinamas "Horizontal rule", HTML kode uþraðomas þyme "<hr/>. Daþnai naudojamas ir kitas elementas "<br/>", kuris atitinka, tiesiog perkëlimà á kità eilutæ.
  c) Teksto ávedimo laukelis - elementas tekstui ávesti. Paletëje vadinamas "Input (text)", HTML kode uþraðomas þyme "<input type="text" />".
  d) Mygtukas - elementas mygtukui atvaizduoti. Paletëje vadinamas "Input (button)", HTML kode uþraðomas þyme "<input type="button"/>". Mygtukui taip pat daþnai nustatoma savybë "value", tada jis turi pavadinimà, pvz. "<input type="button" value="Mygtukas 1"/>" sukurs mygtukà, kuris turës savo viduje tekstà "Mygtukas 1".
2. Kad bûtø paprasèiau koreguoti dokumentus, rekomenduoju ásijungti "HTML (Web Forms)" rëþimà, tai padaroma Visual Studio lange virð pirmojo sukurto .html failo paspaudus deðiná pelës klaviðà ir pasirinkus "Open With", tada paþymëjus HTML (Web Forms) Editor ir paspaudus mygtukà "Set as Default". Tai atlikus failo koregavimo lange apaèioje kairtëje bus mygtukai "Design", "Split" ir "Source", siûlyèiau naudoti "Split". Plaèiau apie ðiuos mygtukus:
  a) Design - rodomas tik pusplapio vaizdas be HTML kodo. Tokiame koregavimo rëþime galima tiesiog dëlioti elementus ir paletës ir keisti savybës pelës pagalba, koreguoti HTML kodo rankomis negalima.
  b) Source - rodomas tik HTML puslapio kodas ir visas puslapis koreguojamas keièiant kodà.
  c) Split - apjungiami Design ir Source langai, t.y. rodomas tiek HTML kodas, tiek puslapio vaizdas.


##Eiga

1. Sukurkite naujà Visual Studio ASP.NET projektà:
  a) Pasirenkate File -> New -> Project
  b) Ið ðablonø pasirenkate Visaul C# -> Web -> ASP.NET Web Application Project
  c) Lange "New ASP.NET Project" pasirenkate Empty (kadangi kursime paprasèiausià HTML puslapá) ir atþymite varnelæ "Host in the Cloud".
2. Pridëkite naujà HTML failà (Project -> Add New Item... -> HTML Page).
3. Pakoreguokite failà taip, kad gautumëte norimà vaizdà. 
  a) Á puslapá ádëkite DIV konteinerá (<div></div> elementas HTML kode arba Div elementas ið paletës).
  b) Konteineryje ádëkite tris horizontalias linijas (<hr/> elementas HTML kode arba "Horizontal Rule" elementas ið paletës).
  c) Po pirmosios horizontaliosios linijos paraðykite tekstà "Teksto laukelis" ir áterpkite tekstinio laukelio elementà (<input type="text"/> elementas HTML kode arba "Input (text)" elementas ið paletës.
  d) Po antrosios horizontaliosios linijos áterpkite du mygtuko elementus (<input type="button"/> elementas HTML kode arba "Input (Button)" elementas ið paletës).
  e) Pakeiskite mygtukø savybes "value" atitinkamai á "Mygtukas 1" ir "Mygtukas 2".
4. Paleiskite puslapá pasirinkæ Debug -> Start Debugging.