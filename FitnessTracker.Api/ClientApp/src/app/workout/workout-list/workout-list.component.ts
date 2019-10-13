import { Component, OnInit } from '@angular/core';
import { WorkoutService } from '../shared/workout.service';
import { WorkoutList } from '../shared/models/workout-list.model';
import { NotificationService } from 'src/app/shared/notification.service';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { Workout } from '../shared/models/workout.model';

@Component({
  selector: 'app-workout-list',
  templateUrl: './workout-list.component.html',
  styleUrls: ['./workout-list.component.css']
})
export class WorkoutListComponent implements OnInit {
  workoutList: WorkoutList = new WorkoutList();

  constructor(
    private workoutService: WorkoutService,
    private notificationService: NotificationService,
    private spinnerService: SpinnerService) { }

  ngOnInit() {
    this.spinnerService.show();
    this.workoutService.getWorkouts()
      .subscribe(response => {
        this.spinnerService.hide();
        this.workoutList = response;
      }, error => {
        this.spinnerService.hide();
        this.notificationService.showError(error);
      });
  }

  deleteWorkout(workout: Workout) {
    this.spinnerService.show();
    this.workoutService.deleteWorkout(workout.id)
      .subscribe(_ => {
        this.spinnerService.hide();
        this.notificationService.showSuccess('Workout deleted.');
        this.workoutList.workouts = this.workoutList.workouts.filter(w => w.id != workout.id);
      }, error => {
        this.spinnerService.hide();
        this.notificationService.showError(error);
      });
  }
}
