
using csharp_abstract_animals;

var dog = new Cane();
var passero = new Passerotto();
var eagle = new Aquila();
var dolphin = new Delfino();
var seaBird = new PulcinellaDiMare();

dog.Verso();
passero.Verso();
eagle.Verso();
dolphin.Verso();
seaBird.Verso();

dog.Mangia();
passero.Mangia();
eagle.Mangia();
dolphin.Mangia();
seaBird.Mangia();

dog.Dormi();
passero.Dormi();   
eagle.Dormi();
dolphin.Dormi();
seaBird.Dormi();

dog.Nuota();
passero.Vola();
eagle.Vola();
dolphin.Nuota();
seaBird.Vola();
seaBird.Nuota();