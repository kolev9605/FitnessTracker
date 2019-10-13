import { Injectable } from '@angular/core';
import { Workout } from './models/workout.model';
import { HttpClient, HttpParams } from '@angular/common/http';
import { WorkoutList } from './models/workout-list.model';
import { catchError } from 'rxjs/operators';
import { ErrorService } from 'src/app/shared/error.service';
import { ExerciseList } from './models/exercise-list.model';
import { AddWorkout } from './models/add-workout.model';

@Injectable({
  providedIn: 'root'
})
export class WorkoutService {

  constructor(private http: HttpClient, private errorService: ErrorService) { }

  getWorkouts() {
    return this.http.get<WorkoutList>('https://localhost:5001/api/workouts/getall')
      .pipe(catchError(this.errorService.handleError));
  }

  getExercises() {
    return this.http.get<ExerciseList>('https://localhost:5001/api/exercises/getall')
      .pipe(catchError(this.errorService.handleError));
  }

  addWorkout(workout: AddWorkout) {
    return this.http.post('https://localhost:5001/api/workouts/add', workout)
      .pipe(catchError(this.errorService.handleError));
  }

  deleteWorkout(id: number) {
    const params = new HttpParams()
      .set('id', String(id));

    return this.http.delete('https://localhost:5001/api/workouts/delete', {params})
      .pipe(catchError(this.errorService.handleError));
  }
}