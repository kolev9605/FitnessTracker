import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, FormBuilder, FormArray } from '@angular/forms';

@Component({
  selector: 'app-add-workout',
  templateUrl: './add-workout.component.html',
  styleUrls: ['./add-workout.component.css']
})
export class AddWorkoutComponent implements OnInit {
  addWorkoutForm: FormGroup;
  workoutItems: FormArray;

  constructor(private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.addWorkoutForm = this.formBuilder.group({
      'name': this.formBuilder.control(null),
      'workoutItems': this.formBuilder.array([ this.createWorkoutItemGroup() ])
    });
  }

  createWorkoutItemGroup(): FormGroup {
    return this.formBuilder.group({
      exerciseName: null,
      reps: null,
      sets: null
    });
  }

  addItem(): void {
    this.workoutItems = this.addWorkoutForm.get('workoutItems') as FormArray;
    console.log(this.workoutItems);
    this.workoutItems.push(this.createWorkoutItemGroup());
  }

  removeItem(index): void {
    this.workoutItems = this.addWorkoutForm.get('workoutItems') as FormArray;
    this.workoutItems.removeAt(index);
  }

  onSubmit() {
    console.log(this.addWorkoutForm);
  }

}
