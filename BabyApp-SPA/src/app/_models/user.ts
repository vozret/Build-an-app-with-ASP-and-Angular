import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    // name and surname -> knownAs
    nameAndSurname: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    lookingFor: string;
    availableHours: string;
    introduction?: string;
    interests?: string;
    photos?: Photo[];
}
