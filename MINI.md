##Mini uþduotëlës.

#1 tema: Konsolinës aplikacijos
1 uþd. 
  Sàlyga: Sukurkite konsolinæ programëlæ, kuri viskà, kà áveda vartotojas, iðveda atvirkðèiai (pvz. ávedus "Labas", iðvedama "sabaL"). 
  Patarimai: naudokite string klasës standartinæ komandà Reverse(), pvz.: string s = "Labas"; s = s.Reverse();
2 uþd.
  Sàlyga: Sukurkite konsolinæ programëlæ, kuri iðspausdintø á ekranà viskà, kas pateikiama kaip programos paleidimo parametrai (t.y. jei programa vadinasi programele.exe ir ji paleidþiama ið komandinës eilutës surinkus "programele.exe test1 test2 test3", tai atskirose eilutëse turëtø bûti iðspausdinamas tekstas "test1", "test2", "test3").
  Patarimai: naudokite masyvà "args", kuris yra standartinio metodo Main vienintelis parametras.
3 uþd.
  Sàlyga: Sukurkite konsolinæ programëlæ, kuriai pasileidus tiesiog iðvedamas vienas simbolis "#", taèiau po to galima klaviatûros pagalba (paspaudus vienà ið klaviðø "a", "s", "d", "w") ðá simbolá judinti ekrane, t.y. paspaudus klaviðà "d" simbolis pajuda per vienà simbolá á deðinæ, paspaudus "s", simbolis pajuda viena eilute þemiau.
  Patarimai: 1) nuskaityti paspaudam klaviðui naudokite komandà Console.ReadKey(true); 2) pakeisti kursoriaus pozicijà naudokite komandà Console.SetCursorPosition(x, y)
4 uþd.
  Sàlyga: Sukurkite konsolinæ programëlæ, kuri lauktø paspaudþiamo klaviðo ir paspaudus tam tikrà klaviðà iðvestø garsiná signalà
  Patarimai: 1) nuskaityti paspaudam klaviðui naudokite komandà Console.ReadKey(true); 2) iðvesti garsiniam signalui naudokite komandà Console.Beep(frequency, duration)

#2 tema: darbalaukio (desktop'inës, Windows) aplikacijos
1 uþd. 
  Sàlyga: Bëgiojantis mygtukas - sukurkite WindowsForms aplikacijà, kurioje bûtø vienas mygtukas, taèiau virð jo uþvedus pele, mygtukas pabëgtø.
  Patarimai: naudokite mygtuko ávyká MouseMove bei mygtuko savybes button1.Location.X ir button1.Location.Y;
2 uþd. 
  Sàlyga: Sukurkite WindowsForms aplikacijà, kurios lango apaèioje bûtø bûsenos juosta, o joje progreso indikatorius. Taip pat formoje bûtø mygtukas, kurá paspaudus, progreso indikatorius padidëtø vienetu.
  Patarimai: naudokite komponentus StatusStrip ir ToolStripProgressBar.
3 uþd.
  Sàlyga: Sukurkite programëlæ, kuris paleidus padaro ekrano vaizdo kopijà (screenshot'à) ir já uþsideda kaip savo vaizdà (kitaip tariant atrodo, jog matome desktop'à, taèiau kà bepaspaustume, niekas neveikia)
  Patarimai:
    1) Pasirinkite formos savybæ FormBorderStyle á "None".
    2) Galite pasinaudoti ðia programinio kodo iðkarpa, kad padaryti ekrano screenshot'à:
            Bitmap _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(_screenBitmap))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 _screenBitmap.Size,
                                 CopyPixelOperation.SourceCopy);
            }     
    3) Screenshot'à reikia daryti iki formos pasirodymo (kad nebûtø paèios formos vaizdo), tam panaudokite formos ávyká "Load".
    4) Paveiksliukà geriausia uþdëti vos vos forma pasirodo, tam naudokite formos ávyká "Shown"
4 uþd.
  Sàlyga: Sukurkite programëlæ - tekstø redaktoriø, kuriame paþymëjus tekstà ir paspaudus deðiná pelës klaviðà pasirodytø kontekstinis meniu su punktai "Nuspalvinti raudonai" ir "Nuspalvinti mëlynai", pasirinkus vienà ið punktø tik paþymëtas tekstas bûtø nuspalvinamas pasirinkta spalva.
  Patarimai:
    1) Kontekstiniam meniu rodyti naudokite komponentà "ContextMenuStrip" ir elemente, ties kuriuo turëtø pasirodyti ðis kontekstinis meniu pakeiskite savybæ "Context Menu Strip".
    2) Kaip teksto redagavimo elementà naudokite komponentà "RichTextBox", nes tik ðiame elemente galima keisti spalvà daliai teksto.
    3) Paþymëto teksto spalvà galima pakeisti su komandà richTextBox1.SelectionColor = Color.Red;

#3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF - Windows Presentation Foundation).
1 uþd.
  Sàlyga: Sukurkite WPF programëlæ, kuri atrodytø kaip Notepad programa. Programa nieko neturi daryti, taèiau turëti visiðkai toká pat vaizdà kaip ir Notepad.
  Patarimai:
    1) Programëlei turëtø uþtekti ðiø elementø: Grid, TextBox, Menu, ScrollViewer, dël groþio dar galima panaudoti Border elementà.
    2) Norint, kad TextBox elementas leistø suvesti keliø eiluèiø tekstà, reikëtø nurodyti savybes TextWrapping="Wrap" ir AcceptsReturn="True".
2 uþd.
  Sàlyga: Sukurkite WPF programëlæ, kuri susidëtø ið vieno mygtuko ir paveiksliuko elemento (tarkime linksmo veiduko), paspaudus mygtukà paveiksliukas turëtø vienà kartà apsisukti 360 laipsniø, sukimosi animacija turëtø trukti apie 2 sekundes.
  Patarimai:
    1) Programëlei sukurti reikia apibrëþti paveiksliuko animacijà. Tam geriausia naudoti áranká Blend for Visual Studio 2013.
    2) Yra keli bûdai paleisti animacijà: a) ið programinio kodo iðkviesti storyboard.Begin(), kur storyboard - animacijos objektas b) Blend redaktoriuje uþdëti trigerá, kad paspaudus mygtukà sugrotø animacija.
3 uþd.
  Sàlyga: Sukurkite WPF programëlæ, kuri susidëtø ið vieno mygtuko, uþvedus pele virð mygtuko turëtø iðsiðaukti kokia nors animacija - pvz. mygtukas judantis tai á kairæ, tai á deðinæ. Kas nori sudëtingiau - padarykite, kad ta pati animacija iðsikviestø paneðus pele langà.
4 uþd.
  Sàlyga: Sukurkite WPF programëlæ, kuri susidëtø ið teksto ávedimo lauko ir mygtuko, paspaudus mygtukà, teksto spalva pasikeistø á raudonà. Taip pat visi elementai (mygtukas ir teksto laukelis) turi bûti animuoti - suktis 3D erdvëje apie Z aðá.
  Patarimai:
    1) 3D efektui pasiekti visus formos elementus sudëkite á elementà "Viewport2DVisual3D", o já idëkite á elementà "Viewport3D".
    2) Pradëti programëlæ galite nuo ðio pavyzdþio:
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
