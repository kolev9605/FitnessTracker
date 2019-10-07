import { Injectable } from '@angular/core';
import { Workout } from './models/workout.model';
import { HttpClient } from '@angular/common/http';
import { WorkoutList } from './models/workout-list.model';
import { catchError } from 'rxjs/operators';
import { ErrorService } from 'src/app/shared/error.service';

@Injectable({
  providedIn: 'root'
})
export class WorkoutService {

  constructor(private http: HttpClient, private errorService: ErrorService) { }

  getWorkouts() {
    return this.http.get<WorkoutList>('https://localhost:5001/api/workout/getall')
      .pipe(catchError(this.errorService.handleError));
  }

  addWorkout(workout: Workout) {
  }
}