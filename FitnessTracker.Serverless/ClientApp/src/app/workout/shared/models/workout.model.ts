import { WorkoutItem } from './workout-item.model';

export class Workout {
    public id: number;
    public name: string;
    public workoutItems: WorkoutItem[];
}