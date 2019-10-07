import { Injectable } from '@angular/core';
import { RegisterModel } from './models/register.model';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { LoginModel } from './models/login.model';
import { ResponseModel } from './models/response.model';
import { catchError, tap } from 'rxjs/operators';
import { throwError, Subject, BehaviorSubject } from 'rxjs';
import { UserModel } from './models/user.model';
import { LoginResponseModel } from './models/loginResponse.model';
import { RegisterResponseModel } from './models/registerResponse.model';
import { Router } from '@angular/router';
import { environment } from '../../../environments/environment';
import { ErrorService } from 'src/app/shared/error.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private tokenExpirationTimer;

  public user: BehaviorSubject<UserModel>;
  constructor(
    private httpClient: HttpClient, 
    private router: Router,
    private errorService: ErrorService) {
    this.user = new BehaviorSubject<UserModel>(null);
  }

  register(registerModel: RegisterModel) {
    const registerUrl = environment.baseApiUrl + 'account/register';

    return this.httpClient.post<RegisterResponseModel>(registerUrl, registerModel)
      .pipe(
        catchError(this.errorService.handleError),
        tap(responseModel => {
          this.handleAuthentication(responseModel);
        })
      );
  }

  login(loginModel: LoginModel) {
    const loginUrl =  environment.baseApiUrl + 'account/login';

    return this.httpClient.post<LoginResponseModel>(loginUrl, loginModel)
      .pipe(
        catchError(this.errorService.handleError),
        tap(responseModel => {
          this.handleAuthentication(responseModel);
        })
      );
  }

  logout() {
    this.user.next(null);
    localStorage.clear();
    this.router.navigate(['/login']);
    if (this.tokenExpirationTimer) {
      clearTimeout(this.tokenExpirationTimer);
    }

    this.tokenExpirationTimer = null;
  }

  tryLogin() {
    const user : {
      email: string,
      id: string,
      _token: string,
      _tokenExpirationDate: string
    } = JSON.parse(localStorage.getItem('user'));

    if (!user) {
      return;
    }

    const userModel = new UserModel(
      user.email, 
      user.id, 
      user._token, 
      new Date(user._tokenExpirationDate)
    );

    if (userModel.token) {
      this.user.next(userModel);
      this.setupAutoLogoutTimer(new Date(user._tokenExpirationDate));        
    }
  }

  private handleAuthentication(responseModel: ResponseModel) {
    const user = new UserModel(
      responseModel.email,
      responseModel.userId,
      responseModel.token,
      responseModel.expirationDate);

    this.user.next(user);
    this.setupAutoLogoutTimer(responseModel.expirationDate);
    localStorage.setItem('user', JSON.stringify(user));
  }

  private setupAutoLogoutTimer(tokenExpirationDate: Date) {
    let tokenExpirationInMiliseconds = 
    new Date(tokenExpirationDate).getTime() - new Date().getTime();
    console.log('timer: ' + tokenExpirationInMiliseconds);

    this.tokenExpirationTimer = setTimeout(() => {
      console.log('Auto logout fired');
      this.logout();
    }, tokenExpirationInMiliseconds)
  }
}
