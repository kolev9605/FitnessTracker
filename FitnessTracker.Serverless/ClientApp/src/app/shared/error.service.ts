import { HttpErrorResponse } from '@angular/common/http';
import { throwError } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {  
  
  public handleError(errorResponse: HttpErrorResponse) {
    let errorMessage;
    if (!errorResponse.error || !errorResponse.error.errorMessage) {
      errorMessage = 'Something went wrong :/';
    } else {
      errorMessage = errorResponse.error.errorMessage;
    }

    return throwError(errorMessage);
  }
}