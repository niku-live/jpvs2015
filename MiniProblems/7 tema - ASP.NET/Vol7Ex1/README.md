##Sąlyga

Sukurkite minimalų ASP.NET puslapį, kuriame būtų teksto įvedimo laukelis, vienas mygtukas ir vienas nekoreguojamas teksto laukelis, paspaudus mygtuką į nekoreguojamą laukelį turi būti įrašomas teksto įvedimo laukelio turinys, o teksto įvedimo laukelis išvalomas.

##Patarimai
```html
1. Užduočiai atlikti prisireiks šių elementų (iš įrankių paletės):
  a) Button - paprasčiausias mygtukas (turintis panašiais savybės kaip Windows Forms aplikacijoje).
  b) TextBox - teksto įvedimo laukelis (turintis panašiais savybės kaip Windows Forms aplikacijoje).
  c) Label - teksto atvaizdavimo laukelis, kuris nėra koreguojamas.
```

##Eiga
```html
1. Sukurkite naują Visual Studio ASP.NET projektą:
  a) Pasirenkate File -> New -> Project
  b) Iš šablonų pasirenkate Visaul C# -> Web -> ASP.NET Web Application Project
  c) Lange "New ASP.NET Project" pasirenkate Empty ir atžymite varnelę "Host in the Cloud" ir pažymėkite varnelę "Web Forms".
2. Pridėkite naują Web Form failą (Project -> Add New Item... -> Web Form).
3. Pakoreguokite failą taip, kad gautumėte norimą vaizdą. 
  a) Į puslapį iš paletės įdėkite 1 "Label" elementą, tada 1 "TextBox" elementą, tada 1 "Button" elementą, tada 2 Label elementus.
  b) Pakeiskite pirmojo Label elemento savybę "Text" į "Tekstas:".
  c) Pakeiskite mygtuko savybę "Text" į "Išvalyk".
  d) Pakeiskite antrojo Label elemento savybę "Text" į "Prieš tai buvo įvesta:".
  e) Pakeiskite trečiojo Label elemento savybę "Text" į "".
4. Mygtukui padasrykite, kad jį paspaudus būtų vykdoma tokia C# funkcija:
        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = TextBox1.Text;
            TextBox1.Text = "";
        }
5. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```