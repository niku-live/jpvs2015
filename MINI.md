#Mini užduotėlės.

##1 tema: Konsolinės aplikacijos
#1 užd. 
  Sąlyga: Sukurkite konsolinę programėlę, kuri viską, ką įveda vartotojas, išveda atvirkščiai (pvz. įvedus "Labas", išvedama "sabaL"). 
  Patarimai: naudokite string klasės standartinę komandą Reverse(), pvz.: string s = "Labas"; s = s.Reverse();
#2 užd.
  Sąlyga: Sukurkite konsolinę programėlę, kuri išspausdintų į ekraną viską, kas pateikiama kaip programos paleidimo parametrai (t.y. jei programa vadinasi programele.exe ir ji paleidžiama iš komandinės eilutės surinkus "programele.exe test1 test2 test3", tai atskirose eilutėse turėtų būti išspausdinamas tekstas "test1", "test2", "test3").
  Patarimai: naudokite masyvą "args", kuris yra standartinio metodo Main vienintelis parametras.
#3 užd.
  Sąlyga: Sukurkite konsolinę programėlę, kuriai pasileidus tiesiog išvedamas vienas simbolis "#", tačiau po to galima klaviatūros pagalba (paspaudus vieną iš klavišų "a", "s", "d", "w") šį simbolį judinti ekrane, t.y. paspaudus klavišą "d" simbolis pajuda per vieną simbolį į dešinę, paspaudus "s", simbolis pajuda viena eilute žemiau.
  Patarimai: 1) nuskaityti paspaudam klavišui naudokite komandą Console.ReadKey(true); 2) pakeisti kursoriaus poziciją naudokite komandą Console.SetCursorPosition(x, y)
#4 užd.
  Sąlyga: Sukurkite konsolinę programėlę, kuri lauktų paspaudžiamo klavišo ir paspaudus tam tikrą klavišą išvestų garsinį signalą
  Patarimai: 1) nuskaityti paspaudam klavišui naudokite komandą Console.ReadKey(true); 2) išvesti garsiniam signalui naudokite komandą Console.Beep(frequency, duration)

##2 tema: darbalaukio (desktop'inės, Windows) aplikacijos
#1 užd. 
  Sąlyga: Bėgiojantis mygtukas - sukurkite WindowsForms aplikaciją, kurioje būtų vienas mygtukas, tačiau virš jo užvedus pele, mygtukas pabėgtų.
  Patarimai: naudokite mygtuko įvykį MouseMove bei mygtuko savybes button1.Location.X ir button1.Location.Y;
#2 užd. 
  Sąlyga: Sukurkite WindowsForms aplikaciją, kurios lango apačioje būtų būsenos juosta, o joje progreso indikatorius. Taip pat formoje būtų mygtukas, kurį paspaudus, progreso indikatorius padidėtų vienetu.
  Patarimai: naudokite komponentus StatusStrip ir ToolStripProgressBar.
#3 užd.
  Sąlyga: Sukurkite programėlę, kuris paleidus padaro ekrano vaizdo kopiją (screenshot'ą) ir jį užsideda kaip savo vaizdą (kitaip tariant atrodo, jog matome desktop'ą, tačiau ką bepaspaustume, niekas neveikia)
  Patarimai:
    1) Pasirinkite formos savybę FormBorderStyle į "None".
    2) Galite pasinaudoti šia programinio kodo iškarpa, kad padaryti ekrano screenshot'ą:
            Bitmap _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(_screenBitmap))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 _screenBitmap.Size,
                                 CopyPixelOperation.SourceCopy);
            }     
    3) Screenshot'ą reikia daryti iki formos pasirodymo (kad nebūtų pačios formos vaizdo), tam panaudokite formos įvykį "Load".
    4) Paveiksliuką geriausia uždėti vos vos forma pasirodo, tam naudokite formos įvykį "Shown"
#4 užd.
  Sąlyga: Sukurkite programėlę - tekstų redaktorių, kuriame pažymėjus tekstą ir paspaudus dešinį pelės klavišą pasirodytų kontekstinis meniu su punktai "Nuspalvinti raudonai" ir "Nuspalvinti mėlynai", pasirinkus vieną iš punktų tik pažymėtas tekstas būtų nuspalvinamas pasirinkta spalva.
  Patarimai:
    1) Kontekstiniam meniu rodyti naudokite komponentą "ContextMenuStrip" ir elemente, ties kuriuo turėtų pasirodyti šis kontekstinis meniu pakeiskite savybę "Context Menu Strip".
    2) Kaip teksto redagavimo elementą naudokite komponentą "RichTextBox", nes tik šiame elemente galima keisti spalvą daliai teksto.
    3) Pažymėto teksto spalvą galima pakeisti su komandą richTextBox1.SelectionColor = Color.Red;

##3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF - Windows Presentation Foundation).
#1 užd.
  Sąlyga: Sukurkite WPF programėlę, kuri atrodytų kaip Notepad programa. Programa nieko neturi daryti, tačiau turėti visiškai tokį pat vaizdą kaip ir Notepad.
  Patarimai:
    1) Programėlei turėtų užtekti šių elementų: Grid, TextBox, Menu, ScrollViewer, dėl grožio dar galima panaudoti Border elementą.
    2) Norint, kad TextBox elementas leistų suvesti kelių eilučių tekstą, reikėtų nurodyti savybes TextWrapping="Wrap" ir AcceptsReturn="True".
#2 užd.
  Sąlyga: Sukurkite WPF programėlę, kuri susidėtų iš vieno mygtuko ir paveiksliuko elemento (tarkime linksmo veiduko), paspaudus mygtuką paveiksliukas turėtų vieną kartą apsisukti 360 laipsnių, sukimosi animacija turėtų trukti apie 2 sekundes.
  Patarimai:
    1) Programėlei sukurti reikia apibrėžti paveiksliuko animaciją. Tam geriausia naudoti įrankį Blend for Visual Studio 2013.
    2) Yra keli būdai paleisti animaciją: a) iš programinio kodo iškviesti storyboard.Begin(), kur storyboard - animacijos objektas b) Blend redaktoriuje uždėti trigerį, kad paspaudus mygtuką sugrotų animacija.
#3 užd.
  Sąlyga: Sukurkite WPF programėlę, kuri susidėtų iš vieno mygtuko, užvedus pele virš mygtuko turėtų išsišaukti kokia nors animacija - pvz. mygtukas judantis tai į kairę, tai į dešinę. Kas nori sudėtingiau - padarykite, kad ta pati animacija išsikviestų panešus pele langą.
#4 užd.
  Sąlyga: Sukurkite WPF programėlę, kuri susidėtų iš teksto įvedimo lauko ir mygtuko, paspaudus mygtuką, teksto spalva pasikeistų į raudoną. Taip pat visi elementai (mygtukas ir teksto laukelis) turi būti animuoti - suktis 3D erdvėje apie Z ašį.
  Patarimai:
    1) 3D efektui pasiekti visus formos elementus sudėkite į elementą "Viewport2DVisual3D", o jį idėkite į elementą "Viewport3D".
    2) Pradėti programėlę galite nuo šio pavyzdžio:
<Viewport3D>
    <Viewport3D.Camera>
        <PerspectiveCamera Position="0, 0, 4"/>
    </Viewport3D.Camera>
    <Viewport2DVisual3D x:Name="v2dv3d">
        <Viewport2DVisual3D.Transform>
            <RotateTransform3D>
                <RotateTransform3D.Rotation>
                    <AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
                </RotateTransform3D.Rotation>
            </RotateTransform3D>
        </Viewport2DVisual3D.Transform>
        <Viewport2DVisual3D.Geometry>
            <MeshGeometry3D Positions="-1,1,0 -1,-1,0 1,-1,0 1,1,0"
                    TextureCoordinates="0,0 0,1 1,1 1,0" TriangleIndices="0 1 2 0 2 3"/>
        </Viewport2DVisual3D.Geometry>

        <Viewport2DVisual3D.Material>
            <DiffuseMaterial Viewport2DVisual3D.IsVisualHostMaterial="True" Brush="White"/>
        </Viewport2DVisual3D.Material>
        <Button Content="Hello, 3D">
            <Button.Triggers>
                <EventTrigger RoutedEvent="FrameworkElement.Loaded">
                    <BeginStoryboard>
                        <Storyboard RepeatBehavior="Forever">
                            <Rotation3DAnimation Storyboard.TargetName="v2dv3d"
                                                    Storyboard.TargetProperty="(Viewport2DVisual3D.Transform).(RotateTransform3D.Rotation)"
                                                    Duration="0:0:2"
                                                    BeginTime="0:0:0">
                                <Rotation3DAnimation.From>
                                    <AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
                                </Rotation3DAnimation.From>
                                <Rotation3DAnimation.To>
                                    <AxisAngleRotation3D Angle="90" Axis="0, 1, 0" />
                                </Rotation3DAnimation.To>
                            </Rotation3DAnimation>
                            <Rotation3DAnimation Storyboard.TargetName="v2dv3d"
                                                    Storyboard.TargetProperty="(Viewport2DVisual3D.Transform).(RotateTransform3D.Rotation)"
                                                    Duration="0:0:2"
                                                    BeginTime="0:0:2">
                                <Rotation3DAnimation.From>
                                    <AxisAngleRotation3D Angle="-90" Axis="0, 1, 0" />
                                </Rotation3DAnimation.From>
                                <Rotation3DAnimation.To>
                                    <AxisAngleRotation3D Angle="0" Axis="0, 1, 0" />
                                </Rotation3DAnimation.To>
                            </Rotation3DAnimation>
                        </Storyboard>
                    </BeginStoryboard>
                </EventTrigger>
            </Button.Triggers>
        </Button>
    </Viewport2DVisual3D>
    <ModelVisual3D>
        <ModelVisual3D.Content>
            <DirectionalLight Color="#FFFFFFFF" Direction="0,0,-1"/>
        </ModelVisual3D.Content>
    </ModelVisual3D>
</Viewport3D>
