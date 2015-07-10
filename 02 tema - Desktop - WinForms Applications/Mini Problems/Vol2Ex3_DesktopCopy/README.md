##2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 3 užd.

#Sąlyga

Sukurkite programėlę, kuris paleidus padaro ekrano vaizdo kopiją (screenshot'ą) ir jį užsideda kaip savo vaizdą (kitaip tariant atrodo, jog matome desktop'ą, tačiau ką bepaspaustume, niekas neveikia)

#Patarimai

1. Pasirinkite formos savybę **FormBorderStyle** į **"None"**.
2. Galite pasinaudoti šia programinio kodo iškarpa, kad padaryti ekrano screenshot'ą:
	
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
	
3. Screenshot'ą reikia daryti iki formos pasirodymo (kad nebūtų pačios formos vaizdo), tam panaudokite formos įvykį **"Load"**.
4. Paveiksliuką geriausia uždėti vos vos forma pasirodo, tam naudokite formos įvykį **"Shown"**.
