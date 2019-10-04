import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-workout',
  templateUrl: './workout.component.html',
  styleUrls: ['./workout.component.css']
})
export class WorkoutComponent implements OnInit {
  data;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.http.get('https://localhost:5001/api/workout/getall')
      .subscribe(data => {
        console.log(data);
      })
  }

}
