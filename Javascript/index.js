console.log('hello');

/*
naam;leeftijd
joske;13
jantje;14
mieke;15
*/

var personen = [];

var p1 = {};
p1.naam = "joske";
p1.leeftijd = 13;
personen[0] = p1;

personen.push({ naam: "jantje", leeftijd: 14 });

var p3 = { naam: "mieke", leeftijd: 15 };
personen.push(p3);

personen.forEach(function (p) {
    console.log(p.naam + " is " + p.leeftijd)
});
