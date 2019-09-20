import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
let WorkoutService = class WorkoutService {
    constructor() {
        this.workouts = [{
                duration: 0,
                name: "Upper workout 1",
                items: [{
                        exercise: {
                            name: "Bench press"
                        },
                        repetitions: 8,
                        restInterval: 120,
                        sets: 3
                    }]
            }
        ];
    }
    getWorkouts() {
        return this.workouts;
    }
    addWorkout(workout) {
        this.workouts.push(workout);
    }
};
WorkoutService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], WorkoutService);
export { WorkoutService };
//# sourceMappingURL=workout.service.js.map