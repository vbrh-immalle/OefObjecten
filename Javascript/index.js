console.log('hello');

/*
naam;leeftijd
joske;13
jantje;14
mieke;15
*/

var personen = [];

personen.push({ naam: "joske", leeftijd: 13 });
personen.push({ naam: "jantje", leeftijd: 14 });
personen.push({ naam: "mieke", leeftijd: 15 });

personen.forEach(p => console.log(p.naam + " is " + p.leeftijd));
