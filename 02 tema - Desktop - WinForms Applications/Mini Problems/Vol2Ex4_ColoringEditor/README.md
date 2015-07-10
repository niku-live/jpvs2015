##2 tema: darbalaukio (desktop'inės, Windows) aplikacijos - Mini užduotėlės - 4 užd.

#Sąlyga

Sukurkite programėlę - tekstų redaktorių, kuriame pažymėjus tekstą ir paspaudus dešinį pelės klavišą pasirodytų kontekstinis meniu su punktai "Nuspalvinti raudonai" ir "Nuspalvinti mėlynai", pasirinkus vieną iš punktų tik pažymėtas tekstas būtų nuspalvinamas pasirinkta spalva.

#Patarimai

1. Kontekstiniam meniu rodyti naudokite komponentą **"ContextMenuStrip"** ir elemente, ties kuriuo turėtų pasirodyti šis kontekstinis meniu pakeiskite savybę **"Context Menu Strip"**.
2. Kaip teksto redagavimo elementą naudokite komponentą **"RichTextBox"**, nes tik šiame elemente galima keisti spalvą daliai teksto.
3. Pažymėto teksto spalvą galima pakeisti su komandą `richTextBox1.SelectionColor = Color.Red`;
