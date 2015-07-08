##Sąlyga

3 užduotimi sukurtą puslapį papildykite, kad elemento parodymas / slėpimas būtų animuotas.

##Patarimai
```html
1. Animacijai geriausia naudoti jQuery biblioteką.
2. Su JQuery vietoj document.getElementById("left") geriau naudoti tiesiog $("#left"), tai daro tą patį, bet užsirašo trumpiau.
3. JQuery elemento paslėpimui / parodymui galima naudoti komandas .hide(anim_time) / .show(anim_time), kur anim_time - kiek laiko trunka animacija.
```

##Eiga
```html
1. Atidarykite anksčiau sukurtą projektą.
2. HTML faile pridėkite nuorodą į JQuery biblioteką - tiesiog prirašykite "<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>"
3. Papildykite Javascript failą (pakeiskite funkciją hideShow):
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
4. Paleiskite puslapį pasirinkę Debug -> Start Debugging.
```