import { IPerson, PersonCategory } from './IPerson';

export abstract class Person implements IPerson
{
    Category: PersonCategory;
    private DateOfBirth: Date;

    constructor(dateOfBirth: Date){
        this.DateOfBirth = dateOfBirth;
    }

    abstract canSignContracts(): boolean

    printDetails(): void
    {
        console.log('Person: ');
        console.log('Data urodzenia: ' + `${ this.DateOfBirth.toDateString() }`);
        console.log('Kategoria: ' + `${PersonCategory[this.Category]}`);
        console.log('Moze podpisac?: ' + `${ this.canSignContracts() }`)
    }

    printDetailsHTML(): string
    {
        let info = `${ this.DateOfBirth.toDateString() }, ` + `${PersonCategory[this.Category]}, `+ `${ this.canSignContracts() }. `;
        return info;
    }
}