##Mini u�duot�l�s.

#1 tema: Konsolin�s aplikacijos
1 u�d. 
  S�lyga: Sukurkite konsolin� program�l�, kuri visk�, k� �veda vartotojas, i�veda atvirk��iai (pvz. �vedus "Labas", i�vedama "sabaL"). 
  Patarimai: naudokite string klas�s standartin� komand� Reverse(), pvz.: string s = "Labas"; s = s.Reverse();
2 u�d.
  S�lyga: Sukurkite konsolin� program�l�, kuri i�spausdint� � ekran� visk�, kas pateikiama kaip programos paleidimo parametrai (t.y. jei programa vadinasi programele.exe ir ji paleid�iama i� komandin�s eilut�s surinkus "programele.exe test1 test2 test3", tai atskirose eilut�se tur�t� b�ti i�spausdinamas tekstas "test1", "test2", "test3").
  Patarimai: naudokite masyv� "args", kuris yra standartinio metodo Main vienintelis parametras.
3 u�d.
  S�lyga: Sukurkite konsolin� program�l�, kuriai pasileidus tiesiog i�vedamas vienas simbolis "#", ta�iau po to galima klaviat�ros pagalba (paspaudus vien� i� klavi�� "a", "s", "d", "w") �� simbol� judinti ekrane, t.y. paspaudus klavi�� "d" simbolis pajuda per vien� simbol� � de�in�, paspaudus "s", simbolis pajuda viena eilute �emiau.
  Patarimai: 1) nuskaityti paspaudam klavi�ui naudokite komand� Console.ReadKey(true); 2) pakeisti kursoriaus pozicij� naudokite komand� Console.SetCursorPosition(x, y)
4 u�d.
  S�lyga: Sukurkite konsolin� program�l�, kuri laukt� paspaud�iamo klavi�o ir paspaudus tam tikr� klavi�� i�vest� garsin� signal�
  Patarimai: 1) nuskaityti paspaudam klavi�ui naudokite komand� Console.ReadKey(true); 2) i�vesti garsiniam signalui naudokite komand� Console.Beep(frequency, duration)

#2 tema: darbalaukio (desktop'in�s, Windows) aplikacijos
1 u�d. 
  S�lyga: B�giojantis mygtukas - sukurkite WindowsForms aplikacij�, kurioje b�t� vienas mygtukas, ta�iau vir� jo u�vedus pele, mygtukas pab�gt�.
  Patarimai: naudokite mygtuko �vyk� MouseMove bei mygtuko savybes button1.Location.X ir button1.Location.Y;
2 u�d. 
  S�lyga: Sukurkite WindowsForms aplikacij�, kurios lango apa�ioje b�t� b�senos juosta, o joje progreso indikatorius. Taip pat formoje b�t� mygtukas, kur� paspaudus, progreso indikatorius padid�t� vienetu.
  Patarimai: naudokite komponentus StatusStrip ir ToolStripProgressBar.
3 u�d.
  S�lyga: Sukurkite program�l�, kuris paleidus padaro ekrano vaizdo kopij� (screenshot'�) ir j� u�sideda kaip savo vaizd� (kitaip tariant atrodo, jog matome desktop'�, ta�iau k� bepaspaustume, niekas neveikia)
  Patarimai:
    1) Pasirinkite formos savyb� FormBorderStyle � "None".
    2) Galite pasinaudoti �ia programinio kodo i�karpa, kad padaryti ekrano screenshot'�:
            Bitmap _screenBitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            using (Graphics g = Graphics.FromImage(_screenBitmap))
            {
                g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                 Screen.PrimaryScreen.Bounds.Y,
                                 0, 0,
                                 _screenBitmap.Size,
                                 CopyPixelOperation.SourceCopy);
            }     
    3) Screenshot'� reikia daryti iki formos pasirodymo (kad neb�t� pa�ios formos vaizdo), tam panaudokite formos �vyk� "Load".
    4) Paveiksliuk� geriausia u�d�ti vos vos forma pasirodo, tam naudokite formos �vyk� "Shown"
4 u�d.
  S�lyga: Sukurkite program�l� - tekst� redaktori�, kuriame pa�ym�jus tekst� ir paspaudus de�in� pel�s klavi�� pasirodyt� kontekstinis meniu su punktai "Nuspalvinti raudonai" ir "Nuspalvinti m�lynai", pasirinkus vien� i� punkt� tik pa�ym�tas tekstas b�t� nuspalvinamas pasirinkta spalva.
  Patarimai:
    1) Kontekstiniam meniu rodyti naudokite komponent� "ContextMenuStrip" ir elemente, ties kuriuo tur�t� pasirodyti �is kontekstinis meniu pakeiskite savyb� "Context Menu Strip".
    2) Kaip teksto redagavimo element� naudokite komponent� "RichTextBox", nes tik �iame elemente galima keisti spalv� daliai teksto.
    3) Pa�ym�to teksto spalv� galima pakeisti su komand� richTextBox1.SelectionColor = Color.Red;

#3 tema: darbalaukio aplikacijos II (aplikacijos paremtos WPF - Windows Presentation Foundation).
1 u�d.
  S�lyga: Sukurkite WPF program�l�, kuri atrodyt� kaip Notepad programa. Programa nieko neturi daryti, ta�iau tur�ti visi�kai tok� pat vaizd� kaip ir Notepad.
  Patarimai:
    1) Program�lei tur�t� u�tekti �i� element�: Grid, TextBox, Menu, ScrollViewer, d�l gro�io dar galima panaudoti Border element�.
    2) Norint, kad TextBox elementas leist� suvesti keli� eilu�i� tekst�, reik�t� nurodyti savybes TextWrapping="Wrap" ir AcceptsReturn="True".
2 u�d.
  S�lyga: Sukurkite WPF program�l�, kuri susid�t� i� vieno mygtuko ir paveiksliuko elemento (tarkime linksmo veiduko), paspaudus mygtuk� paveiksliukas tur�t� vien� kart� apsisukti 360 laipsni�, sukimosi animacija tur�t� trukti apie 2 sekundes.
  Patarimai:
    1) Program�lei sukurti reikia apibr��ti paveiksliuko animacij�. Tam geriausia naudoti �rank� Blend for Visual Studio 2013.
    2) Yra keli b�dai paleisti animacij�: a) i� programinio kodo i�kviesti storyboard.Begin(), kur storyboard - animacijos objektas b) Blend redaktoriuje u�d�ti triger�, kad paspaudus mygtuk� sugrot� animacija.
3 u�d.
  S�lyga: Sukurkite WPF program�l�, kuri susid�t� i� vieno mygtuko, u�vedus pele vir� mygtuko tur�t� i�si�aukti kokia nors animacija - pvz. mygtukas judantis tai � kair�, tai � de�in�. Kas nori sud�tingiau - padarykite, kad ta pati animacija i�sikviest� pane�us pele lang�.
4 u�d.
  S�lyga: Sukurkite WPF program�l�, kuri susid�t� i� teksto �vedimo lauko ir mygtuko, paspaudus mygtuk�, teksto spalva pasikeist� � raudon�. Taip pat visi elementai (mygtukas ir teksto laukelis) turi b�ti animuoti - suktis 3D erdv�je apie Z a��.
  Patarimai:
    1) 3D efektui pasiekti visus formos elementus sud�kite � element� "Viewport2DVisual3D", o j� id�kite � element� "Viewport3D".
    2) Prad�ti program�l� galite nuo �io pavyzd�io:
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
