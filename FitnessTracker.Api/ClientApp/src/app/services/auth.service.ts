import { Injectable } from '@angular/core';
import { RegisterModel } from '../models/auth/register.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { LoginModel } from '../models/auth/login.model';
import { ResponseModel } from '../models/auth/response.model';
import { catchError, tap } from 'rxjs/operators';
import { throwError, Subject } from 'rxjs';
import { UserModel } from '../models/auth/user.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  user: Subject<UserModel>;
  constructor(private httpClient: HttpClient) { 
    this.user = new Subject<UserModel>();
  }

  register(registerModel: RegisterModel) {
    let registerUrl = 'https://localhost:5001/api/account/register';

    return this.httpClient.post<ResponseModel>(registerUrl, registerModel)      
      .pipe(
        catchError(this.handleError),
        tap(this.handleAuthentication)
      );
  }

  login(loginModel: LoginModel) {
    let loginUrl = 'https://localhost:5001/api/account/login';

    return this.httpClient.post<ResponseModel>(loginUrl, loginModel)
      .pipe(
        catchError(this.handleError),
        tap(responseModel => {
          let user = new UserModel(
            responseModel.email, 
            responseModel.userId, 
            responseModel.token, 
            responseModel.expirationDate);
      
            console.log(this.user);
          this.user.next(user);
        })
      );
  }

  private handleAuthentication(responseModel: ResponseModel) {
console.log(this.user);
  }

  private handleError(errorResponse: HttpErrorResponse) {
    let errorMessage;
    if (!errorResponse.error || !errorResponse.error.errorMessage) {
      errorMessage = 'Something went wrong :/';
    } else {
      errorMessage = errorResponse.error.errorMessage;
    }

    return throwError(errorMessage);
  }
}
