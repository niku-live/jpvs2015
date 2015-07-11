#7 tema - Internetinės aplikacijos - ASP.NET - Mini užduotėlės - 1 užd.

##Sąlyga

Sukurkite minimalų ASP.NET puslapį, kuriame būtų teksto įvedimo laukelis, vienas mygtukas ir vienas nekoreguojamas teksto laukelis, paspaudus mygtuką į nekoreguojamą laukelį turi būti įrašomas teksto įvedimo laukelio turinys, o teksto įvedimo laukelis išvalomas.

##Patarimai

1. Užduočiai atlikti prisireiks šių elementų (iš įrankių paletės):
  1. **Button** - paprasčiausias mygtukas (turintis panašiais savybės kaip *Windows Forms* aplikacijoje).
  2. **TextBox** - teksto įvedimo laukelis (turintis panašiais savybės kaip *Windows Forms* aplikacijoje).
  3. **Label** - teksto atvaizdavimo laukelis, kuris nėra koreguojamas.

##Eiga

1. Sukurkite naują *Visual Studio ASP.NET* projektą:
  1. Pasirenkate *File -> New -> Project*
  2. Iš šablonų pasirenkate *Visaul C# -> Web -> ASP.NET Web Application Project*
  3. Lange **"New ASP.NET Project"** pasirenkate Empty ir atžymite varnelę **"Host in the Cloud"** ir pažymėkite varnelę **"Web Forms"**.
2. Pridėkite naują *Web Form* failą (*Project -> Add New Item... -> Web Form*).
3. Pakoreguokite failą taip, kad gautumėte norimą vaizdą. 
  1. Į puslapį iš paletės įdėkite 1 **Label** elementą, tada 1 **TextBox** elementą, tada 1 **Button** elementą ir tada 2 **Label** elementus.
  2. Pakeiskite pirmojo **Label** elemento savybę **Text** į **"Tekstas:"**.
  3. Pakeiskite mygtuko savybę **Text** į **Išvalyk**.
  4. Pakeiskite antrojo **Label** elemento savybę **Text** į **"Prieš tai buvo įvesta:"**.
  5. Pakeiskite trečiojo **Label** elemento savybę **"Text"** į **""**.
4. Mygtukui padasrykite, kad jį paspaudus būtų vykdoma tokia C# funkcija:
```csharp
protected void Button1_Click(object sender, EventArgs e)
{
	Label3.Text = TextBox1.Text;
	TextBox1.Text = "";
}
```
5. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.