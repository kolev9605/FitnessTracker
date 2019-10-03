import { WorkoutItem } from './workout-item.model';

export class Workout {
    public name: string;
    public duration: number;
    public items: WorkoutItem[];
}