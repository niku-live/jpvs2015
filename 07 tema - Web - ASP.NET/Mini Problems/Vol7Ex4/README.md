#7 tema - Internetinės aplikacijos - ASP.NET - Mini užduotėlės - 4 užd.

##Sąlyga

3 užduotimi sukurtą puslapį pakoreguokite taip, kad kiekvienos eilutės pirmame stulpelyje būtų nuoroda "Select", kurią paspaudus atsidarytų naujas puslapis, kuriame būtų atvaizduojama tik pasirinktos eilutės informacija.
![Galimas puslapio vaizdas](https://raw.githubusercontent.com/niku-live/jpvs2015/master/07%20tema%20-%20Web%20-%20ASP.NET/Mini%20Problems/Vol7Ex4/example4_1.png)
![Galimas puslapio vaizdas2](https://raw.githubusercontent.com/niku-live/jpvs2015/master/07%20tema%20-%20Web%20-%20ASP.NET/Mini%20Problems/Vol7Ex4/example4_2.png)

##Patarimai

1. Vienos eilutės duomenims atvaizduoti geriausia naudoti **FormView** komponentą (pasirenkamą iš paletės).
2. Tam, kad **GridView-- komponentas pavaizduotų **Select** mygtuką pakanka redaktoriuje pažymėti GridView komponentą ir pasirinkti **Enable Selection**
3. Norint iš vieno puslapio atidaryti kitą užtenka iškviesti komandą `Response.Redirect(adresas)`, kur **adresas** - naujojo puslapio adresas.
4. Norint puslapiui perduoti parametrus, parametro vertes galima įrašyti į adresą, pvz. adresas `test.aspx?parametras=verte` reiškia, kad bus atidarytas puslapis **test.aspx** ir jam perduotas parametras **parametras**, kurio vertė bus **verte**.
5. Pasiiimti perduotus parametrus galima pasinaudojus komandas `Request["parametras"]`, kur **parametras** - parametro vardas.
6. Norint, kad **XmlDataSource** duomenų šaltinis visada rodytų į konkrečią eilutę, užtenka teisingai nurodyti **XPath** savybę, pvz. `Data/User[2]` reikš, kad reikalinga tik 2 eilutė. 

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. Pakoreguokite GridView elementą, kad jame būtų mygtukas "Select" (Pažymėkite GridView komponentą ir pasirinkite **Enable Selection**).
3. Pasirinkite GridView įvykį **SelectedIndexChanged** ir priskirkite jam tokią funkciją:

```csharp
	protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
	{            
		Response.Redirect(String.Format("details.aspx?id={0}", GridView1.SelectedIndex + 1));
	}
```

4. Pridėkite naują *Web Form* failą (*Project -> Add New Item... -> Web Form*). Pavadinkite naująjį failą "details.aspx".
5. Į puslapį įtraukite komponentą **XmlDataSource** (tiesiog pasirinkite iš paletės), komponentui užpildykite savybes taip:
  1. **DataFile** - šioje savybėje reikia įrašyti sukurto failo pavadinimą.
  2. **XPath** * - ši savybė nurodo, kuriuos duomenis norime atvaizduoti iš failo. Nurodykite reikšmė **"Data/User"**.
6. Į puslapį įtraukite komponentą **FormView**. Pakeiskite savybes taip:
  1. **DataSourceID** - šioje savybėje nurodomas duomenų šaltinis. Pasirinkite šaltinį, sukurtą 4 punktu (tikriausiai pavadinimas bus *XmlDataSource1*)
  2. Pakoreguokite savybes aprašančias išvaizdą.
7. Puslapyje pakeiskite funkcija **Form_Load** taip:
```csharp
	protected void Page_Load(object sender, EventArgs e)
	{
		XmlDataSource1.XPath = String.Format("Data/User[{0}]", this.Request["id"]);
	}
```
8. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.