# Document Prototype — Himoya savollari

**1. Prototype Pattern nima uchun ishlatiladi?**
Mavjud obyektdan nusxa olib yangi obyekt yaratish uchun. Obyektni noldan yaratish qimmat yoki murakkab bo'lsa
(ko'p maydon, sozlash, ma'lumot yuklash), tayyor prototipni nusxalash osonroq. Mijoz kod aniq klassni bilmasdan
`Clone()` orqali yangi obyekt oladi.

**2. `Clone()` metodi qanday ishlaydi?**
Obyekt o'zining nusxasini yaratib qaytaradi. Bu loyihada `Clone()` copy constructor'ni chaqiradi:
`new Document(this)` — barcha maydonlar yangi obyektga ko'chiriladi, `Tags` uchun esa yangi ro'yxat yaratiladi.
Natijada har safar yangi obyekt qaytadi (`original == copy` → `false`).

**3. Shallow Copy va Deep Copy o'rtasidagi farq nima?**
- *Shallow Copy* — faqat obyektning o'zi nusxalanadi, ichidagi havolalar (masalan `List<string> Tags`) umumiy bo'lib qoladi.
  Bir nusxada tegni o'zgartirsangiz, original ham o'zgaradi. C# da `MemberwiseClone()` shallow copy qiladi.
- *Deep Copy* — ichki obyektlar ham alohida nusxalanadi (`new List<string>(source.Tags)`).
  Nusxalar bir-biriga va originalga ta'sir qilmaydi.

Dastur ikkalasini ham ko'rsatadi: deep copy da original teglari o'zgarmaydi, shallow copy da esa `"XATO"` tegi originalga ham qo'shiladi.

**4. `DocumentFactory` klassi qanday vazifani bajaradi?**
Prototip hujjatni saqlaydi va `CloneDocument()` orqali undan yangi nusxalar beradi. Mijoz kod hujjatni qanday
nusxalashni bilishi shart emas. `SetDocument()` bilan prototipni almashtirish mumkin.
