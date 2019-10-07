import { Component, OnInit, Input } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Workout } from '../../shared/models/workout.model';

@Component({
  selector: 'app-workout',
  templateUrl: './workout.component.html',
  styleUrls: ['./workout.component.css']
})
export class WorkoutComponent implements OnInit {
  @Input() workout: Workout;

  constructor(private http: HttpClient) { }

  ngOnInit() {
  }

}
