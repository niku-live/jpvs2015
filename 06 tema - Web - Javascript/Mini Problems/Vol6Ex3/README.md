#6 tema - Internetinės aplikacijos - Javascript - Mini užduotys - 3 užd.

##Sąlyga

2 užduotimi sukurtą puslapį papildykite, kad paspaudus trečią mygtuką būtų paslepiama arba vėl parodoma kairė meniu juosta (kitaip tariant div elementas, kurios `id="left"`).

##Patarimai

1. Norint *Javascript* pagalba pasiekti kurį nors puslapio elementą reikėtų naudoti komandą `var elementas = document.getElementById("Button1");`, kur **Button1** - norimo gauti elemento id, **elementas** - kintamojo vardas, kuriam priskirsime gautą puslapio elementą.
2. Norint *Javascript* pagalba paslėpti elementą reikėtų naudoti kodą: `elementas.style.display = "none";`.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
2. Papildykite **Javascript** failą (pridėkite naują funkciją):
```javascript
function hideShow() {
    var left_elem = document.getElementById("left");
    if (left_elem.style.display != "none") {
        left_elem.style.display = "none";
    }
    else {
        left_elem.style.display = "inline-block";
    }
}
```
3. HTML faile trečiam mygtukui nustatykite savybę `onclick="hideShow()"`.
4. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.