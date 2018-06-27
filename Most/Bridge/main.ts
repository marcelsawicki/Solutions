import { KPlyta } from './KPlyta';
import { Tlok } from './PlytaInterface';
import { Nagrywanie } from './Nagrywanie';
import { Odczytywanie } from './Odczytywanie';

let ob1 = new KPlyta(Tlok.dvd, "TDK", new Nagrywanie());
let ob2 = new KPlyta(Tlok.cd, "Dysan", new Odczytywanie());
ob1.Akcja();
console.log(ob1.Get() + "\n");
ob2.Akcja();
console.log(ob2.Get() + "\n");
ob1.Set("Verbatim", Tlok.bd);
ob1.Akcja();
console.log(ob1.Get() + "\n");