import { Injectable } from '@angular/core';
import { Workout } from './models/workout.model';

@Injectable({
  providedIn: 'root'
})
export class WorkoutService {

  private workouts: Workout[] = [{
      duration: 0,
      name: "Upper workout 1",
      items: [{
        exercise: {
            name: "Bench press"
        },
        repetitions: 8,
        restInterval: 120,
        sets: 3
      }]
    }
  ];

  constructor() { }

  getWorkouts() {
    return this.workouts;
  }

  addWorkout(workout: Workout) {
    this.workouts.push(workout);
  }
}