import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { HeaderComponent } from './layout/header/header.component';
import { FooterComponent } from './layout/footer/footer.component';
import { WorkoutComponent } from './workout/workout-list/workout/workout.component';
import { ProgressSpinnerComponent } from './shared/progress-spinner/progress-spinner.component';
import { WorkoutListComponent } from './workout/workout-list/workout-list.component';
import { MaterialUiModule } from './material-ui.module';
import { AddWorkoutComponent } from './workout/add-workout/add-workout.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    WorkoutComponent,
    ProgressSpinnerComponent,
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
    MaterialUiModule,
    NgbModule
  ],
  providers: [],
  bootstrap: [AppComponent],
  entryComponents: [ProgressSpinnerComponent]
})

export class AppModule {}