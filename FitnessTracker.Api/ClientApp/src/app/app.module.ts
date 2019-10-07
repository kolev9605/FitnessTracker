import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import 'hammerjs';

import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { WorkoutComponent } from './workout/workout-list/workout/workout.component';
import { LoginComponent } from './auth/login/login.component';
import { RegisterComponent } from './auth/register/register.component';
import { ProgressSpinnerComponent } from './shared/progress-spinner/progress-spinner.component';
import { AuthInterceptor } from './auth/shared/auth.interceptor';
import { HomeComponent } from './home/home.component';
import { WorkoutListComponent } from './workout/workout-list/workout-list.component';
import { MaterialUiModule } from './material-ui.module';
import { AddWorkoutComponent } from './workout/add-workout/add-workout.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    WorkoutComponent,
    LoginComponent,
    RegisterComponent,
    ProgressSpinnerComponent,
    HomeComponent,
    WorkoutListComponent,
    AddWorkoutComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FormsModule,
    HttpClientModule,
    ReactiveFormsModule,
    MaterialUiModule
  ],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: AuthInterceptor,
      multi: true
    }
  ],
  bootstrap: [AppComponent],
  entryComponents: [ProgressSpinnerComponent]
})

export class AppModule {}