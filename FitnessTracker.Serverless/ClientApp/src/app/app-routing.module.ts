import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { AuthGuard } from './auth/shared/auth-guard';
import { WorkoutListComponent } from './workout/workout-list/workout-list.component';
import { AddWorkoutComponent } from './workout/add-workout/add-workout.component';

const routes: Routes = [
  { path: '', component: WorkoutListComponent, canActivate: [AuthGuard] },
  { path: 'workouts', component: WorkoutListComponent, canActivate: [AuthGuard] },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'add-workout', component: AddWorkoutComponent, canActivate: [AuthGuard]}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }