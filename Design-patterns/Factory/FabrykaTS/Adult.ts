import { Person } from './Person';
import { PersonCategory } from './IPerson';

export class Adult extends Person
{
    constructor(dateOfBirth: Date){
        super(dateOfBirth);
        this.Category =  PersonCategory.Adult;
    }
    canSignContracts(): boolean { return true; }
}