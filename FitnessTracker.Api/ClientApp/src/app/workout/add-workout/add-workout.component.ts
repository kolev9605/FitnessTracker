import { Component, OnInit } from '@angular/core';
import { FormGroup, Validators, FormBuilder, FormArray } from '@angular/forms';
import { WorkoutService } from '../shared/workout.service';
import { NotificationService } from 'src/app/shared/notification.service';
import { ExerciseList } from '../shared/models/exercise-list.model';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { AddWorkout } from '../shared/models/add-workout.model';
import { MuscleGroupList } from '../shared/models/muscle-group-list.model';

@Component({
  selector: 'app-add-workout',
  templateUrl: './add-workout.component.html',
  styleUrls: ['./add-workout.component.css']
})
export class AddWorkoutComponent implements OnInit {
  addWorkoutForm: FormGroup;
  workoutItems: FormArray;
  exerciseList: ExerciseList = new ExerciseList();
  muscleGroupList: MuscleGroupList = new MuscleGroupList();

  constructor(
    private formBuilder: FormBuilder,
    private workoutService: WorkoutService,
    private notificationService: NotificationService,
    private router: Router,
    private spinnerService: SpinnerService) { }

  ngOnInit() {
    this.spinnerService.show();
    this.workoutService.getExercises()
      .subscribe(response => {
        this.spinnerService.hide();
        this.exerciseList = response;
      }, error => {
        this.spinnerService.hide();
        this.notificationService.showError(error);
      });

      this.workoutService.getMuscleGroups()
      .subscribe(response => {
        this.spinnerService.hide();
        this.muscleGroupList = response;
      }, error => {
        this.spinnerService.hide();
        this.notificationService.showError(error);
      });

    this.addWorkoutForm = this.formBuilder.group({
      'name': this.formBuilder.control(null, Validators.required),
      'workoutItems': this.formBuilder.array([ this.createWorkoutItemGroup() ])
    });
  }

  createWorkoutItemGroup(): FormGroup {
    return this.formBuilder.group({
      exerciseId: [null, Validators.required],
      reps: [null, [Validators.required, Validators.min(0)]],
      sets: [null, [Validators.required, Validators.min(0)]],
      weight: [null, [Validators.required, Validators.min(0)]]
    });
  }

  addItem(): void {
    this.workoutItems = this.addWorkoutForm.get('workoutItems') as FormArray;
    this.workoutItems.push(this.createWorkoutItemGroup());
  }

  removeItem(index): void {
    this.workoutItems = this.addWorkoutForm.get('workoutItems') as FormArray;
    this.workoutItems.removeAt(index);
  }

  onSubmit(): void {
    const workout: AddWorkout = {
      name: this.addWorkoutForm.get('name').value,
      workoutItems: this.addWorkoutForm.get('workoutItems').value

    };

    this.spinnerService.show();
    this.workoutService.addWorkout(workout)
      .subscribe(_ => {
        this.spinnerService.hide();
        this.notificationService.showSuccess('Workout added.')
        this.router.navigate(['/workouts']);
      }, error => {
        this.spinnerService.hide();
        this.notificationService.showError(error)
      });
  }
}