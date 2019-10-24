import { Infant } from './Infant';
import { Child } from './Child';
import { Adult } from './Adult';
import { IPerson } from './IPerson';

export class PersonFactory {
    getPerson(dateOfBirth: Date): IPerson
    {
        let dateNow = new Date(); // as default is set current date
        let currentMonth = dateNow.getMonth() + 1;
        let currentDate = dateNow.getDate();

        let dateTwoYearsAgo = new Date(dateNow.getFullYear() - 2, currentMonth, currentDate);
        let date18YearsAgo = new Date(dateNow.getFullYear() - 18, currentMonth, currentDate);

        if(dateOfBirth >= dateTwoYearsAgo)
        {
            return new Infant(dateOfBirth);
        }

        if(dateOfBirth >= date18YearsAgo)
        {
            return new Child(dateOfBirth);
        }

        return new Adult(dateOfBirth);
    }
}