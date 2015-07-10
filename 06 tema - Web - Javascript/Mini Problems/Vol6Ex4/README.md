#6 tema - Internetinės aplikacijos - Javascript - Mini užduotys - 4 užd.

##Sąlyga

3 užduotimi sukurtą puslapį papildykite, kad elemento parodymas / slėpimas būtų animuotas.

##Patarimai

1. Animacijai geriausia naudoti *jQuery* biblioteką.
2. Su *jQuery* vietoj `document.getElementById("left")` geriau naudoti tiesiog `$("#left")`, tai daro tą patį, bet užsirašo trumpiau.
3. *jQuery* elemento paslėpimui / parodymui galima naudoti komandas `.hide(anim_time)` / `.show(anim_time)`, kur **anim_time** - kiek laiko trunka animacija.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. HTML faile pridėkite nuorodą į jQuery biblioteką - tiesiog prirašykite `<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>`
3. Papildykite *Javascript* failą (pakeiskite funkciją **hideShow**):
``javascript
var isHidden = false;

function hideShow() {
	if (isHidden)
	{
		isHidden = false;
		$("#left").show(1000);        
	}
	else
	{
		isHidden = true;
		$("#left").hide(1000);
	}
}
```
4. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.