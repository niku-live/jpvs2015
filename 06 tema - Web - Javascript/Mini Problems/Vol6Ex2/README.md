#6 tema - Internetinės aplikacijos - Javascript - Mini užduotys - 2 užd.

##Sąlyga

1 užduotimi sukurtą puslapį papildykite, kad paspaudus pirmą mygtuką būtų išmetamas pranešimas 1 kartą, paspaudus antrą mygtuką -  2 kartus, trečią mygtuką - 3 kartus.

##Patarimai

1. Pakeiskite **click1** funkciją, kad ji priimtų parametrą, o kviečiant **click1** funkciją perduokite parametrą atitinkamai skaičių 1, 2 arba 3.
2. Funkcijoje reikėtų panaudoti **for** ciklą.

##Eiga

1. Atidarykite anksčiau sukurtą projektą.
4. Papildykite *Javascript* failą taip:
```javascript
function click1(count)
{
	alert("paspausta");
	for (var i = 0; i < count; i++)
	{
		alert("paspausta " + i);
	}
	
}
```
3. HTML faile pirmam mygtukui nustatykite savybę `onclick="click1(1)"`, antram - `onclick="click1(2)"`, trečiam - `onclick="click1(3)"`.
4. Paleiskite puslapį pasirinkę *Debug -> Start Debugging*.