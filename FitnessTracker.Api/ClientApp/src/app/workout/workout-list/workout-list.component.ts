import { Component, OnInit } from '@angular/core';
import { WorkoutService } from '../shared/workout.service';
import { WorkoutList } from '../shared/models/workout-list.model';
import { ErrorService } from 'src/app/shared/error.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { Workout } from '../shared/models/workout.model';

@Component({
  selector: 'app-workout-list',
  templateUrl: './workout-list.component.html',
  styleUrls: ['./workout-list.component.css']
})
export class WorkoutListComponent implements OnInit {
  private workoutList: WorkoutList;

  constructor(
    private workoutService: WorkoutService,
    private notificationService: NotificationService) { }

  ngOnInit() {
    this.workoutService.getWorkouts()
      .subscribe(response => {
        this.workoutList = response;
      }, error => {
        this.notificationService.showError(error);
      });
  }

}
