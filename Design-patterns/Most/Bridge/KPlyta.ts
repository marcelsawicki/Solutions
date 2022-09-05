import { Tlok } from './PlytaInterface';
import { Plyta } from './Plyta';
import { PlytaInterface } from './PlytaInterface';

export class KPlyta extends Plyta
{
    constructor(type: Tlok, name: string, plytaInterface: PlytaInterface)
    {
        super(type, name, plytaInterface)

    }
}