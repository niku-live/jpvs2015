##Sąlyga

1 užduotimi sukurtą puslapį pakoreguokite, kad įvestą tekstą paspaudus mygtuką išsaugotų į failą ir kitą kartą paleidus puslapį būtų tekstas užkraunamas iš to failo.

##Patarimai
```html
1. Darbui su failais reikia naudotis tas pačias funkcijas, kokias naudojome kurdami konsolines arba Windows Forms aplikacijas.
2. Kai puslapis užkraunamas paleidžiama funkcija Page_Load. Ją ir reikėtų koreguoti norint nurodyti, ką padaryti užkrovus puslapį.
```

##Eiga
```html
1. Atidarykite anskčiau sukurtą projektą.
2. Pakoreguokite Button1_Click funkciją taip:
        protected void Button1_Click(object sender, EventArgs e)
        {
            string text = TextBox1.Text;
            Label3.Text = text;
            TextBox1.Text = "";
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Devel\\test.txt");
            System.IO.StreamWriter writer = finfo.CreateText();
            writer.WriteLine(text);
            writer.Close();
        }
		
3. Pakoreguokite Page_Load funkciją taip:
        protected void Page_Load(object sender, EventArgs e)
        {
            System.IO.FileInfo finfo = new System.IO.FileInfo("C:\\Devel\\test.txt");
            if (finfo.Exists)
            {
                System.IO.StreamReader reader = finfo.OpenText();
                string text = reader.ReadLine();
                reader.Close();
                TextBox1.Text = text;
            }
        }
		
4. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```