import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthService } from '../shared/auth.service';
import { LoginModel } from '../shared/models/login.model';
import { SpinnerService } from '../../shared/spinner.service';
import { NotificationService } from '../../shared/notification.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['../shared/auth.css']
})
export class LoginComponent implements OnInit {
  loginForm: FormGroup;
  constructor(
    private authService: AuthService,
    private spinnerService: SpinnerService,
    private notificationService: NotificationService,
    private router: Router) { }

  ngOnInit() {
    this.loginForm = new FormGroup({
      'email': new FormControl(null, [Validators.email, Validators.required]),
      'password': new FormControl(null,  [Validators.required, Validators.minLength(5)])
    });
  }

  onSubmit() {    
    this.spinnerService.show();
    let loginModel: LoginModel = {
      email: this.loginForm.get('email').value,
      password: this.loginForm.get('password').value
    }

    this.authService.login(loginModel).subscribe(result => {
      this.spinnerService.hide();
      this.router.navigate(['/']);
      this.notificationService.showSuccess("yey");
    }, error => {
      this.spinnerService.hide();
      this.notificationService.showError(error);
    });
  }
}
