export enum PersonCategory {
    Infant,
    Child,
    Adult
}

export interface IPerson{
    Category: PersonCategory;
    canSignContracts(): boolean;
    printDetails();
    printDetailsHTML(): string
}