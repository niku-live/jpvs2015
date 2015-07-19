#2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 3 užd.

##Sąlyga

Sukurkite programėlę, kuris paleidus padaro ekrano vaizdo kopiją (screenshot'ą) ir jį užsideda kaip savo vaizdą (kitaip tariant atrodo, jog matome desktop'ą, tačiau ką bepaspaustume, niekas neveikia)

##Patarimai

- Pasirinkite formos savybę **FormBorderStyle** į **"None"**.
- Galite pasinaudoti šia programinio kodo iškarpa, kad padaryti ekrano screenshot'ą:	
```csharp	
Bitmap _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

using (Graphics g = Graphics.FromImage(_screenBitmap))
{
	g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
					 Screen.PrimaryScreen.Bounds.Y,
					 0, 0,
					 _screenBitmap.Size,
					 CopyPixelOperation.SourceCopy);
}     
```		
- Screenshot'ą reikia daryti iki formos pasirodymo (kad nebūtų pačios formos vaizdo), tam panaudokite formos įvykį **"Load"**.
- Paveiksliuką geriausia uždėti vos vos forma pasirodo, tam naudokite formos įvykį **"Shown"**.

##Eiga

- Sukurkite naują darbalaukio aplikacijos projektą:
  1. *Visual Studio* lange pasirinkite **File -> New -> Project...**.
  2. Iš siūlomų projektų šablonų pasirinkite **Visual C# -> Windows Desktop -> Windows Forms Application**.
  3. Įveskite pageidaujamą projekto pavadinimą ir spauskite **OK**.
- Atidarykite formos redaktorių ir pakeiskite formos savybes taip:
  1. **FormBorderStyle** į **None**.
  2. **StartPosition** į **Manual**.
- Įkelkite į formą **PictureBox** elementą, pakeiskite elemento savybę **Dock** į **Fill**.
- Priskirkite formos įvykiui `Load` naują funkciją.
```csharp
private Bitmap _screenBitmap;

private void Form1_Load(object sender, EventArgs e)
{
    _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

    using (Graphics g = Graphics.FromImage(_screenBitmap))
    {
        g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                         Screen.PrimaryScreen.Bounds.Y,
                         0, 0,
                         _screenBitmap.Size,
                         CopyPixelOperation.SourceCopy);
    }
}
```
- Priskirkite formos įvykiui `Shown` naują funkciją.
```csharp
private void Form1_Shown(object sender, EventArgs e)
{
    this.Width = _screenBitmap.Width;
    this.Height = _screenBitmap.Height;
    pictureBox1.Image = _screenBitmap;
    this.Location = new Point(0, 0);
}
```
- Paleiskite programą pasirinkę **Debug -> Start Debugging**.