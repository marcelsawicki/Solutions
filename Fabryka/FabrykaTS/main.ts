import { PersonFactory } from './PersonFactory';

let factory = new PersonFactory();
let p1 = factory.getPerson(new Date(2015, 0, 20));
p1.printDetails();

let p2 = factory.getPerson(new Date(2000, 0, 20));
p2.printDetails();

let p3 = factory.getPerson(new Date(1969, 0, 20));
p3.printDetails()

let anchor = document.getElementById('anchor');
anchor.innerText = p1.printDetailsHTML() + p2.printDetailsHTML() + p3.printDetailsHTML();