import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import { Workout } from '../../shared/models/workout.model';

@Component({
  selector: 'app-workout',
  templateUrl: './workout.component.html',
  styleUrls: ['./workout.component.css']
})
export class WorkoutComponent implements OnInit {
  @Input() workout: Workout;
  @Output() workoutDeleted = new EventEmitter<Workout>();

  constructor() { }

  ngOnInit() {
  }

  onDelete() {
    this.workoutDeleted.emit(this.workout);
  }

  onEdit() {
    console.log('edit')
  }

  onStart() {
    console.log('start')
  }
}
