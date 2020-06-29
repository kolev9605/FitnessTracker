import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WorkoutListComponent } from './workout/workout-list/workout-list.component';
import { AddWorkoutComponent } from './workout/add-workout/add-workout.component';

const routes: Routes = [
  { path: '', component: WorkoutListComponent},
  { path: 'workouts', component: WorkoutListComponent},
  { path: 'add-workout', component: AddWorkoutComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
