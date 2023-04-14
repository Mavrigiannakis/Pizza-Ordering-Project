# Pizza-Ordering-Project
Tämä on C# Windows Forms -sovellus, joka mahdollistaa käyttäjien tilata pizzoja ja juomia.

Sovelluksen tärkein toiminnallisuus on antaa käyttäjien valita pizzoja ja juomia valikosta ja sitten tehdä tilaus. Sovellus laskee tilauksen kokonaishinnan tilattujen tuotteiden määrän ja hinnan perusteella.

Sovellus koostuu yhdestä lomakkeesta (frm_items), joka sisältää erilaisia käyttöliittymän elementtejä, kuten valintaruutuja, tekstiruutuja ja painikkeita.

Seuraavat ovat avainkäyttöliittymäelementit lomakkeella: 

italianCHB, barbequeCHB, veganvegeroniCHB, supremeCHB ja seafoodCHB: Nämä ovat valintaruutuja, jotka mahdollistavat käyttäjien valita pizzoja valikosta.
cocacolaCHB, zeroCHB, pepsiCHB, spriteCHB ja fantaCHB: Nämä ovat valintaruutuja, jotka mahdollistavat käyttäjien valita juomia valikosta.
italianTB, barbequeTB, vegeroniTB, supremeTB, seafoodTB, colaTB, zeroTB, pepsiTB, spriteTB ja fantaTB: Nämä ovat tekstiruutuja, joihin käyttäjät voivat syöttää haluamansa pizzojen tai juomien määrän.
paymentCB: Tämä on yhdistelmäruutu, joka mahdollistaa käyttäjien valita maksutavan.
totalTB: Tämä on tekstiruutu, joka näyttää tilauksen kokonaishinnan.


Seuraavat ovat avaintoiminnot lomakkeessa:

button4_Click: Tämä on tapahtumankäsittelijä "exitBT" -painikkeelle, joka näyttää viestiruudun ja kysyy käyttäjältä, haluavatko he poistua sovelluksesta. Jos käyttäjä valitsee "Kyllä", sovellus sulkeutuu; muussa tapauksessa sovellus jatkaa toimintaansa.
frm_items_Load: Tämä on tapahtumankäsittelijä, joka suoritetaan lomakkeen latautuessa. Se täyttää paymentCB-yhdistelmäruudun maksuvaihtoehdoilla ja poistaa käytöstä kaikki tekstiruudut.
EnableTextBoxes: Tämä on apumetodi, joka poistaa käytöstä kaikki tekstiruudut lomakkeessa rekursiivisesti.
italianCHB_CheckedChanged, barbequeCHB_CheckedChanged, veganvegeroniCHB_CheckedChanged, supremeCHB_CheckedChanged ja seafoodCHB_CheckedChanged: Nämä ovat pizzan valintaruutujen tapahtumankäsittelijöitä, jotka mahdollistavat vastaavan tekstiruudun käytön tai poiston
