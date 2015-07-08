##S�lyga

Panaudojant vien HTML elementus sukurkite puslap� kuris atrodyt� taip:

##Patarimai

1. U�duo�iai atlikti prisireiks �i� element�:
  a) DIV konteineris - standartinis HTML konteineris skirtas kitiems elementams grupuoti. Paprastai visi kiti elementai kuriami DIV konteineri� viduje. Redaktoriaus palet�je elementas vadinasi "Div". HTML kode elementas pradedamas �yme "<div>", o u�baigiamas �yme "</div>", viskas, kad para�yta tarp "<div> ir </div>" laikoma, jog yra DIV konteinerio viduje.
  b) Horizontalios linijos - HTMl elementas per vis� puslap� nupai�antis horizontali� linij�. Palet�je vadinamas "Horizontal rule", HTML kode u�ra�omas �yme "<hr/>. Da�nai naudojamas ir kitas elementas "<br/>", kuris atitinka, tiesiog perk�lim� � kit� eilut�.
  c) Teksto �vedimo laukelis - elementas tekstui �vesti. Palet�je vadinamas "Input (text)", HTML kode u�ra�omas �yme "<input type="text" />".
  d) Mygtukas - elementas mygtukui atvaizduoti. Palet�je vadinamas "Input (button)", HTML kode u�ra�omas �yme "<input type="button"/>". Mygtukui taip pat da�nai nustatoma savyb� "value", tada jis turi pavadinim�, pvz. "<input type="button" value="Mygtukas 1"/>" sukurs mygtuk�, kuris tur�s savo viduje tekst� "Mygtukas 1".
2. Kad b�t� papras�iau koreguoti dokumentus, rekomenduoju �sijungti "HTML (Web Forms)" r��im�, tai padaroma Visual Studio lange vir� pirmojo sukurto .html failo paspaudus de�in� pel�s klavi�� ir pasirinkus "Open With", tada pa�ym�jus HTML (Web Forms) Editor ir paspaudus mygtuk� "Set as Default". Tai atlikus failo koregavimo lange apa�ioje kairt�je bus mygtukai "Design", "Split" ir "Source", si�ly�iau naudoti "Split". Pla�iau apie �iuos mygtukus:
  a) Design - rodomas tik pusplapio vaizdas be HTML kodo. Tokiame koregavimo r��ime galima tiesiog d�lioti elementus ir palet�s ir keisti savyb�s pel�s pagalba, koreguoti HTML kodo rankomis negalima.
  b) Source - rodomas tik HTML puslapio kodas ir visas puslapis koreguojamas kei�iant kod�.
  c) Split - apjungiami Design ir Source langai, t.y. rodomas tiek HTML kodas, tiek puslapio vaizdas.


##Eiga

1. Sukurkite nauj� Visual Studio ASP.NET projekt�:
  a) Pasirenkate File -> New -> Project
  b) I� �ablon� pasirenkate Visaul C# -> Web -> ASP.NET Web Application Project
  c) Lange "New ASP.NET Project" pasirenkate Empty (kadangi kursime papras�iausi� HTML puslap�) ir at�ymite varnel� "Host in the Cloud".
2. Prid�kite nauj� HTML fail� (Project -> Add New Item... -> HTML Page).
3. Pakoreguokite fail� taip, kad gautum�te norim� vaizd�. 
  a) � puslap� �d�kite DIV konteiner� (<div></div> elementas HTML kode arba Div elementas i� palet�s).
  b) Konteineryje �d�kite tris horizontalias linijas (<hr/> elementas HTML kode arba "Horizontal Rule" elementas i� palet�s).
  c) Po pirmosios horizontaliosios linijos para�ykite tekst� "Teksto laukelis" ir �terpkite tekstinio laukelio element� (<input type="text"/> elementas HTML kode arba "Input (text)" elementas i� palet�s.
  d) Po antrosios horizontaliosios linijos �terpkite du mygtuko elementus (<input type="button"/> elementas HTML kode arba "Input (Button)" elementas i� palet�s).
  e) Pakeiskite mygtuk� savybes "value" atitinkamai � "Mygtukas 1" ir "Mygtukas 2".
4. Paleiskite puslap� pasirink� Debug -> Start Debugging.