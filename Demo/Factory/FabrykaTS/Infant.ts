import { Person } from './Person';
import { PersonCategory } from './IPerson';

export class Infant extends Person
{
    constructor(dateOfBirth: Date){
        super(dateOfBirth);
        this.Category =  PersonCategory.Infant;
    }
    canSignContracts(): boolean { return false; }
}