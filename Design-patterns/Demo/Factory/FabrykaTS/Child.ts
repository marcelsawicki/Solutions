import { Person } from './Person';
import { PersonCategory } from './IPerson';

export class Child extends Person
{
    constructor(dateOfBirth: Date){
        super(dateOfBirth);
        this.Category =  PersonCategory.Child;
    }
    canSignContracts(): boolean { return false; }
}